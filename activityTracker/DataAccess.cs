using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activityTracker
{
    public class DataAccess
    {


        public List<Task> GetTasksByDateOverdue(string Deadline)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<Task>("dbo.spTask_GetByDateOverdue @Deadline", new { @Deadline = Deadline }).ToList();
                return output;
            }

        }

        public List<Task> GetTasksByDateSelected(string Deadline)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<Task>("dbo.spTask_GetByDateSelected @Deadline", new { @Deadline = Deadline }).ToList();
                return output;
            }

        }

        public List<Task> GetTasksByTaskStatus(string TaskStatus)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<Task>("dbo.spTask_GetByTaskStatus @TaskStatus", new { @TaskStatus = TaskStatus }).ToList();
                return output;
            }

        }
        public List<Task> GetTasksByUser(string AssignedTo)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<Task>("dbo.spTask_GetByAssignedTo @AssignedTo", new { @AssignedTo = AssignedTo }).ToList();
                return output;
            }

        }

        public List<Task> GetTasksByProject(string ParentProjectTitle)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<Task>("dbo.spTask_GetByProject @ProjectTitle", new { @ProjectTitle = ParentProjectTitle }).ToList();
                return output;
            }

        }

        public List<Task> GetToDoKanbanTasks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<Task>("dbo.spTask_GetTaskIfToDo").ToList();
                return output;
            }

        }
        public List<Task> GetWiPKanbanTasks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<Task>("dbo.spTask_GetTaskIfWiP").ToList();
                return output;
            }

        }
        public List<Task> GetFRKanbanTasks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<Task>("dbo.spTask_GetTaskIfForReview").ToList();
                return output;
            }

        }
        public List<Task> GetComKanbanTasks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<Task>("dbo.spTask_GetTaskIfComplete").ToList();
                return output;
            }

        }
        public List<SubTask> GetToDoKanbanSubTasks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<SubTask>("dbo.spSubTask_GetSubTaskIfToDo").ToList();
                return output;
            }

        }
        public List<SubTask> GetWiPKanbanSubTasks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<SubTask>("dbo.spSubTask_GetSubTaskIfWiP").ToList();
                return output;
            }

        }
        public List<SubTask> GetFRKanbanSubTasks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<SubTask>("dbo.spSubTask_GetSubTaskIfForReview").ToList();
                return output;
            }

        }
        public List<SubTask> GetComKanbanSubTasks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<SubTask>("dbo.spSubTask_GetSubTaskIfComplete").ToList();
                return output;
            }

        }

        public List<Task> GetManageTasks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<Task>("dbo.spTask_GetTasks").ToList();
                return output;
            }

        }

        public List<SubTask> GetManageSubTasks()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<SubTask>("dbo.spSubTask_GetSubTasks").ToList();
                return output;
            }

        }

        public List<Project> GetManageProjects()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<Project>("dbo.spProjects_GetProjects").ToList();
                return output;
            }

        }

        public List<User> GetUsers()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<User>("spUser_GetUsers").ToList();
                return output;
            }

        }

        public List<Task> GetSelectedTasks(string lstSelectTask)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<Task>("dbo.spTask_GetSelectedTask @SelectedTaskID", new { @SelectedTaskID = lstSelectTask }).ToList();
                return output;
            }

        }

        public List<SubTask> GetSelectedSubTasks(string lstSelectSubTask)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                var output = connection.Query<SubTask>("dbo.spSubTask_GetSelectedSubTask @SelectedSubTaskID", new { @SelectedSubTaskID = lstSelectSubTask }).ToList();
                return output;
            }

        }


        public void AddTask(string parentProjectTitle, string taskDeadline, string taskDescription, string taskPriority, string taskProgression, string taskComment, string taskFileLink, string taskStatus, string taskAssignedUser)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
                {
                    List<Task> task = new List<Task>();
                    task.Add(new Task
                    {
                        ParentProjectTitle = parentProjectTitle,
                        Deadline = taskDeadline,
                        Description = taskDescription,
                        Priority = taskPriority,
                        Progression = taskProgression,
                        Comment = taskComment,
                        FileLink = taskFileLink,
                        TaskStatus = taskStatus,
                        AssignedTo = taskAssignedUser,

                    });

                    connection.Execute("dbo.spTasks_AddTask @ParentProjectTitle,@Description,@Deadline,@Priority,@Comment,@Progression,@FileLink,@TaskStatus,@AssignedTo", task);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please ensure you have entered a project and user that exists");
            }
        }

        public void AddProject(string projectTitle)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                List<Project> project = new List<Project>();
                project.Add(new Project
                {
                    ProjectTitle = projectTitle
                });

                connection.Execute("dbo.spProjects_AddProject @ProjectTitle", project);
            }
        }

        public void AddSubTask(string parentTaskID, string subTaskDeadline, string subTaskDescription, string subTaskPriority, string subTaskProgression, string subTaskComment, string subTaskFileLink, string subTaskStatus, string subTaskAssignedUser)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
                {
                    
                    List<SubTask> subTask = new List<SubTask>();
                    subTask.Add(new SubTask
                    {
                        ParentTaskID = parentTaskID,
                        Deadline = subTaskDeadline,
                        Description = subTaskDescription,
                        Priority = subTaskPriority,
                        Progression = subTaskProgression,
                        Comment = subTaskComment,
                        FileLink = subTaskFileLink,
                        SubTaskStatus = subTaskStatus,
                        AssignedTo = subTaskAssignedUser,
                    });

                    connection.Execute("dbo.spSubTask_AddSubTask @ParentTaskID, @Description, @Deadline, @Priority, @Comment, @Progression, @FileLink, @SubTaskStatus, @AssignedTo", subTask);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please ensure you have entered a task and user that exists");
            }
        }


        public void UpdateTask(string parentProjectTitle, string taskDeadline, string taskDescription, string taskPriority, string taskProgression, string taskComment, string taskFileLink, string taskStatus, string taskAssignedUser, string lstSelectTask)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
                {
                    List<Task> task = new List<Task>();
                    task.Add(new Task
                    {
                        ParentProjectTitle = parentProjectTitle,
                        Deadline = taskDeadline,
                        Description = taskDescription,
                        Priority = taskPriority,
                        Progression = taskProgression,
                        Comment = taskComment,
                        FileLink = taskFileLink,
                        TaskStatus = taskStatus,
                        AssignedTo = taskAssignedUser,
                        SelectedTaskID = lstSelectTask

                    });

                    connection.Execute("dbo.spTasks_UpdateTask @ParentProjectTitle,@Description,@Deadline,@Priority,@Comment,@Progression,@FileLink,@TaskStatus,@AssignedTo,@SelectedTaskID", task);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please ensure you have entered a project and user that exists");
            }
        }


        public void UpdateProject(string projectTitle, string selectedProjectTitle)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                List<Project> project = new List<Project>();
                project.Add(new Project
                {
                    ProjectTitle = projectTitle,
                    SelectedProjectTitle = selectedProjectTitle
                });

                connection.Execute("dbo.spProjects_UpdateProject @ProjectTitle, @SelectedProjectTitle", project);
            }
        }

        public void UpdateSubTask(string parentTaskID, string subTaskDeadline, string subTaskDescription, string subTaskPriority, string subTaskProgression, string subTaskComment, string subTaskFileLink, string subTaskStatus, string subTaskAssignedUser, string lstSelectSubTask)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
                {
                    List<SubTask> subTask = new List<SubTask>();
                    subTask.Add(new SubTask
                    {
                        ParentTaskID = parentTaskID,
                        Deadline = subTaskDeadline,
                        Description = subTaskDescription,
                        Priority = subTaskPriority,
                        Progression = subTaskProgression,
                        Comment = subTaskComment,
                        FileLink = subTaskFileLink,
                        SubTaskStatus = subTaskStatus,
                        AssignedTo = subTaskAssignedUser,
                        SelectedSubTaskID = lstSelectSubTask
                    });

                    connection.Execute("dbo.spSubTask_UpdateSubTask @ParentTaskID, @Description, @Deadline, @Priority, @Comment, @Progression, @FileLink, @SubTaskStatus, @AssignedTo, @SelectedSubTaskID", subTask);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please ensure you have entered a task and user that exists");
            }
        }


        public void DeleteTask(string selectedTaskID)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
                {
                    List<Task> task = new List<Task>();
                    task.Add(new Task
                    {
                        SelectedTaskID = selectedTaskID,
                    });

                    connection.Execute("dbo.spTasks_DeleteTask @SelectedTaskID", task);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please ensure you have entered a project and user that exists");
            }
        }


        public void DeleteProject(string selectedProjectTitle)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
            {
                List<Project> project = new List<Project>();
                project.Add(new Project
                {
                    SelectedProjectTitle = selectedProjectTitle,
                });

                connection.Execute("dbo.spProjects_DeleteProject @SelectedProjectTitle", project);
            }
        }


        public void DeleteSubTask(string selectedSubTaskID)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("activityTrackerDB")))
                {
                    List<SubTask> subTask = new List<SubTask>();
                    subTask.Add(new SubTask
                    {
                        SelectedSubTaskID = selectedSubTaskID,                
                    });

                    connection.Execute("dbo.spSubTasks_DeleteSubTask @SelectedSubTaskID", subTask);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please ensure you have entered a task and user that exists");
            }
        }
    }
}


