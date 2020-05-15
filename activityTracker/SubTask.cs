using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activityTracker
{
    public class SubTask
    {
        public string SubTaskID { get; set; }
        public string ParentTaskID { get; set; }
        public string Description { get; set; }
        public string Deadline { get; set; }
        public string Priority { get; set; }
        public string Comment { get; set; }
        public string Progression { get; set; }
        public string FileLink { get; set; }
        public string SubTaskStatus { get; set; }
        public string AssignedTo { get; set; }
        public string SelectedSubTaskID { get; set; }

        public string FullSubTaskInfo
        {
            get
            {
                //SHOULD PRESENT AS 3# Complete question sets for C2M2 with Angus (MCoombes)
                return $"Sub-Task:{ SubTaskID } Parent Task:{ ParentTaskID } -  {Description} ({ AssignedTo })";
            }
        }

        public string FullSelectedSubTaskInfo
        {
            get
            {
                return $"{ SubTaskID }. {Description} ({ AssignedTo }) | Priority: { Priority } | Progression: {Progression}/100 | Task Status: {SubTaskStatus}";
            }
        }
    }
}
