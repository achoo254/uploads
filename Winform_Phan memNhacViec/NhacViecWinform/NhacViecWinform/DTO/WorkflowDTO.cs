using System;

namespace NhacViecWinform.DTO
{
    internal class WorkflowDTO
    {
        private int workflowID;
        private string name;
        private string details;
        private DateTime date_create;
        private DateTime date_start;
        private DateTime date_reminder;
        private int user_create_id;
        private int user_recipent_id;
        private bool active;
        private int category_id;
        private int date_count;
        private bool loop;
        private int positon;
        public int WorkflowID { get => workflowID; set => workflowID = value; }
        public string Name { get => name; set => name = value; }
        public string Details { get => details; set => details = value; }
        public DateTime Date_create { get => date_create; set => date_create = value; }
        public DateTime Date_start { get => date_start; set => date_start = value; }
        public DateTime Date_reminder { get => date_reminder; set => date_reminder = value; }
        public int User_create_id { get => user_create_id; set => user_create_id = value; }
        public int User_recipent_id { get => user_recipent_id; set => user_recipent_id = value; }
        public bool Active { get => active; set => active = value; }
        public int Category_id { get => category_id; set => category_id = value; }
        public int Date_count { get => date_count; set => date_count = value; }
        public bool Loop { get => loop; set => loop = value; }
        public int Positon { get => positon; set => positon = value; }
    }
}