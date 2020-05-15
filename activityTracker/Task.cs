using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activityTracker
{
    public class Task
    {
        public string TaskID { get; set; }
        public string ParentProjectTitle { get; set; }
        public string Description { get; set; }
        public string Deadline { get; set; }
        public string Priority { get; set; }
        public string Comment { get; set; }
        public string Progression { get; set; }
        public string FileLink { get; set; }
        public string TaskStatus { get; set; }
        public string AssignedTo { get; set; }
        public string SelectedTaskID { get; set; }
        public string FullTaskInfo
        {
            get
            {
                //SHOULD PRESENT AS 3# CVI-Galatea: Complete question sets for C2M2 with Angus (MCoombes)
                return $"{ TaskID }. { ParentProjectTitle }: {Description} ({ AssignedTo })";
            }
        }
        public string FullManageTaskInfo
        {
            get
            {
                //SHOULD PRESENT AS 3# CVI-Galatea: Complete question sets for C2M2 with Angus (MCoombes)
                return $"{ TaskID }. { ParentProjectTitle }: {Description} ({ AssignedTo })";
            }
        }

        public string FullSelectedTaskInfo
        {
            get
            {
                return $"{ TaskID }. { ParentProjectTitle }: {Description} ({ AssignedTo }) |Priority: { Priority }| Progression: {Progression}/100| Task Status: {TaskStatus} | Deadline: {Deadline}";
            }
        }
    }
}
