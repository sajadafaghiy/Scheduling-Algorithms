using SchedulingAlgorithms.Extensions;
using SchedulingAlgorithms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SchedulingAlgorithms
{
    /// <summary>
    /// CPU Scheduling Algorithms Simulator: by Sajad Afaghiy
    /// Esfarayen University of Technology
    /// </summary>
    public partial class MainForm : Form
    {
        public List<Process> processesList { get; set; }

        public MainForm()
        {
            InitializeComponent();
            chart.Titles.Clear();
            chart.Titles.Add("CPU Scheduling Algorithms");
            chart.Series.Clear();

            processesList = new List<Process>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Make sure no fields are empty.
            if (txtLabel.Text == string.Empty)
            {
                MessageBox.Show("Please fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                chart.Series.Clear();

                ListViewItem lvi = new ListViewItem(txtLabel.Text);
                lvi.SubItems.Add(nudArrival.Value.ToString());
                lvi.SubItems.Add(nudDuration.Value.ToString());
                ProcessListView.Items.Add(lvi);
                txtLabel.Text = string.Empty;

                UpdateList();

                Draw();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();

            foreach (ListViewItem lvItem in ProcessListView.SelectedItems)
            {
                ProcessListView.Items.Remove(lvItem);
            }

            UpdateList();
            Draw();
        }

        private void nudFBQ_ValueChanged(object sender, EventArgs e)
        {
            chart.Series.Clear();

            UpdateList();
            Draw();
        }

        private void nudRRQ_ValueChanged(object sender, EventArgs e)
        {
            chart.Series.Clear();

            UpdateList();
            Draw();
        }

        void UpdateList()
        {
            processesList.Clear();
            chart.Series.Clear();

            foreach (var item in ProcessListView.Items.Cast<ListViewItem>())
            {
                if (!chart.Series.Any(x => x.Name == item.SubItems[0].Text))
                {
                    chart.Series.Add(item.SubItems[0].Text);
                    chart.Series[item.SubItems[0].Text].ChartType = SeriesChartType.RangeBar;
                    processesList.Add(new Process(item.SubItems[0].Text, Convert.ToInt32(item.SubItems[1].Text), Convert.ToInt32(item.SubItems[2].Text)));
                }
                else
                {
                    MessageBox.Show($"Process name \"{item.SubItems[0].Text}\" already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void Draw()
        {
            chart.ChartAreas[0].AxisY.Interval = 1;
            chart.ChartAreas[0].AxisY.IntervalOffset = 1;

            FCFS(processesList.Clone().ToList());

            RoundRobin(processesList.Clone().ToList(), Convert.ToInt32(nudRRQ.Value));

            ShortestProcessNext(processesList.Clone().ToList());

            ShortestRemainingTime(processesList.Clone().ToList());

            HighestResponseRatioNext(processesList.Clone().ToList());

            Feedback(processesList.Clone().ToList(), Convert.ToInt32(nudFBQ.Value));

            ColumnNaming();
        }

        void FCFS(List<Process> processes)
        {
            int currentTime = 0;

            while (processes.Any(p => p.TimeLeft > 0))
            {
                foreach (var currentProccess in processes.Where(p => p.ArrivalTime <= currentTime && p.TimeLeft > 0))
                {
                    while (currentProccess.TimeLeft > 0)
                    {
                        if (currentProccess.StartTime == null)
                        {
                            currentProccess.StartTime = currentTime;
                        }
                        currentProccess.TimeLeft--;
                        currentProccess.EndTime = currentTime + 1;
                        currentTime++;
                    }
                    chart.Series[currentProccess.Name].Points.AddXY(6, currentProccess.StartTime, currentProccess.EndTime);
                }
            }
        }

        void RoundRobin(List<Process> processes, int quantum)
        {
            int currentTime = 0;
            var queue = new Queue<Process>();

            foreach (var intimeProccess in processes.Where(p => p.ArrivalTime == currentTime && p.TimeLeft > 0))
            {
                queue.Enqueue(intimeProccess);
            }

            while (processes.Any(p => p.TimeLeft > 0))
            {
                if (queue.Count > 0)
                {
                    var currentProccess = queue.Dequeue();

                    for (int i = 0; i < quantum && currentProccess.TimeLeft > 0; i++)
                    {
                        if (currentProccess.StartTime == null)
                        {
                            currentProccess.StartTime = currentTime;
                        }
                        currentProccess.TimeLeft--;
                        currentProccess.EndTime = currentTime + 1;
                        currentTime++;
                        foreach (var intimeProccess in processes.Where(p => p.ArrivalTime == currentTime && p.TimeLeft > 0))
                        {
                            queue.Enqueue(intimeProccess);
                        }
                        chart.Series[currentProccess.Name].Points.AddXY(5, currentTime - 1, currentProccess.EndTime);
                    }

                    if (currentProccess.TimeLeft > 0)
                    {
                        queue.Enqueue(currentProccess);
                    }
                }
                else
                {
                    currentTime++;
                    foreach (var currentProccess in processes.Where(p => p.ArrivalTime == currentTime && p.TimeLeft > 0))
                    {
                        queue.Enqueue(currentProccess);
                    }
                }
            }
        }

        void ShortestProcessNext(List<Process> processes)
        {
            int currentTime = 0;

            while (processes.Any(p => p.TimeLeft > 0))
            {
                var shortest = processes
                    .Where(p => p.ArrivalTime <= currentTime && p.TimeLeft > 0)
                    .OrderBy(p => p.Duration)
                    .FirstOrDefault();

                if (shortest != null)
                {
                    for (int i = 0; i < shortest.Duration; i++)
                    {
                        shortest.TimeLeft--;
                        shortest.StartTime = currentTime;
                        currentTime++;
                        shortest.EndTime = currentTime;
                        chart.Series[shortest.Name].Points.AddXY(4, shortest.StartTime, shortest.EndTime);
                    }
                }
            }
        }

        void ShortestRemainingTime(List<Process> processes)
        {
            int currentTime = 0;

            while (processes.Any(p => p.TimeLeft > 0))
            {
                var currentProccess = processes
                    .Where(p => p.ArrivalTime <= currentTime && p.TimeLeft > 0)
                    .OrderBy(p => p.TimeLeft)
                    .FirstOrDefault();

                if (currentProccess != null)
                {
                    currentProccess.StartTime = currentTime;
                    currentProccess.TimeLeft--;
                    currentProccess.EndTime = currentTime + 1;
                    chart.Series[currentProccess.Name].Points.AddXY(3, currentProccess.StartTime, currentProccess.EndTime);
                }

                currentTime++;
            }
        }

        void HighestResponseRatioNext(List<Process> processes)
        {
            int currentTime = 0;

            while (processes.Any(p => p.TimeLeft > 0))
            {
                var currentProccess = processes
                    .FindAll(p => p.ArrivalTime <= currentTime && p.TimeLeft > 0);

                foreach (var p in currentProccess)
                {
                    p.Priority = (1.0 + (currentTime - p.ArrivalTime) / (double)p.Duration);
                }

                var highest = currentProccess
                    .Aggregate((i1, i2) => i1.Priority > i2.Priority ? i1 : i2);

                while (highest.TimeLeft > 0)
                {
                    highest.StartTime = currentTime;
                    highest.TimeLeft--;
                    highest.EndTime = currentTime + 1;
                    currentTime++;
                    chart.Series[highest.Name].Points.AddXY(2, highest.StartTime, highest.EndTime);
                }
            }
        }

        void Feedback(List<Process> processes, int quantum)
        {
            int currentTime = 0;

            var queue1st = new Queue<Process>();
            var queue2nd = new Queue<Process>();
            var queue3rd = new Queue<Process>();

            foreach (var intimeProccess in processes.Where(p => p.ArrivalTime == currentTime && p.TimeLeft > 0))
            {
                queue1st.Enqueue(intimeProccess);
            }

            while (processes.Any(p => p.TimeLeft > 0))
            {
                if (queue1st.Count > 0)
                {
                    var currentProccess = queue1st.Dequeue();

                    for (int i = 0; i < Math.Pow(quantum, 0) && currentProccess.TimeLeft > 0; i++)
                    {
                        do
                        {
                            currentProccess.StartTime = currentTime;
                            currentProccess.TimeLeft--;
                            currentProccess.EndTime = currentTime + 1;
                            currentTime++;
                            foreach (var intimeProccess in processes.Where(p => p.ArrivalTime == currentTime && p.TimeLeft > 0))
                            {
                                queue1st.Enqueue(intimeProccess);
                            }
                            chart.Series[currentProccess.Name].Points.AddXY(1, currentProccess.StartTime, currentProccess.EndTime);
                        } while (queue1st.Count == 0 && queue2nd.Count == 0 && queue3rd.Count == 0 && currentProccess.TimeLeft > 0);
                    }
                    if (currentProccess.TimeLeft > 0)
                    {
                        queue2nd.Enqueue(currentProccess);
                    }
                }

                else if (queue2nd.Count > 0)
                {
                    var currentProccess = queue2nd.Dequeue();

                    for (int i = 0; i < Math.Pow(quantum, 1) && currentProccess.TimeLeft > 0; i++)
                    {
                        do
                        {
                            currentProccess.StartTime = currentTime;
                            currentProccess.TimeLeft--;
                            currentProccess.EndTime = currentTime + 1;
                            currentTime++;
                            foreach (var intimeProccess in processes.Where(p => p.ArrivalTime == currentTime && p.TimeLeft > 0))
                            {
                                queue1st.Enqueue(intimeProccess);
                            }
                            chart.Series[currentProccess.Name].Points.AddXY(1, currentProccess.StartTime, currentProccess.EndTime);
                        } while (queue1st.Count == 0 && queue2nd.Count == 0 && queue3rd.Count == 0 && currentProccess.TimeLeft > 0);
                    }
                    if (currentProccess.TimeLeft > 0)
                    {
                        queue3rd.Enqueue(currentProccess);
                    }
                }

                else if (queue3rd.Count > 0)
                {
                    var currentProccess = queue3rd.Dequeue();

                    for (int i = 0; i < Math.Pow(quantum, 2) && currentProccess.TimeLeft > 0; i++)
                    {
                        do
                        {
                            currentProccess.StartTime = currentTime;
                            currentProccess.TimeLeft--;
                            currentProccess.EndTime = currentTime + 1;
                            currentTime++;
                            foreach (var intimeProccess in processes.Where(p => p.ArrivalTime == currentTime && p.TimeLeft > 0))
                            {
                                queue1st.Enqueue(intimeProccess);
                            }
                            chart.Series[currentProccess.Name].Points.AddXY(1, currentProccess.StartTime, currentProccess.EndTime);
                        } while (queue1st.Count == 0 && queue2nd.Count == 0 && queue3rd.Count == 0 && currentProccess.TimeLeft > 0);
                    }
                    if (currentProccess.TimeLeft > 0)
                    {
                        queue3rd.Enqueue(currentProccess);
                    }
                }
                else
                {
                    currentTime++;
                    foreach (var intimeProccess in processes.Where(p => p.ArrivalTime == currentTime && p.TimeLeft > 0))
                    {
                        queue1st.Enqueue(intimeProccess);
                    }
                }
            }
        }

        void ColumnNaming()
        {
            foreach (var item in chart.ChartAreas)
            {
                item.AxisX.CustomLabels.Clear();
            }

            try
            {
                int i = 0;

                foreach (DataPoint point in chart.Series[0].Points)
                {
                    switch (i)
                    {
                        case 5:
                            chart.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(6, 7, "FCFS", 0, LabelMarkStyle.None, GridTickTypes.TickMark));
                            break;

                        case 4:
                            chart.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(5, 6, string.Format("RR ({0})", Convert.ToInt32(nudRRQ.Value)), 0, LabelMarkStyle.None, GridTickTypes.TickMark));
                            break;

                        case 3:
                            chart.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(4, 5, "SPN", 0, LabelMarkStyle.None, GridTickTypes.TickMark));
                            break;

                        case 2:
                            chart.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(3, 4, "SRT", 0, LabelMarkStyle.None, GridTickTypes.TickMark));
                            break;

                        case 1:
                            chart.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(2, 3, "HRRN", 0, LabelMarkStyle.None, GridTickTypes.TickMark));
                            break;

                        case 0:
                            chart.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(1, 2, string.Format("FB ({0})", Convert.ToInt32(nudFBQ.Value)), 0, LabelMarkStyle.None, GridTickTypes.TickMark));
                            break;
                    }
                    i++;
                }
            }
            catch { }
        }
    }
}
