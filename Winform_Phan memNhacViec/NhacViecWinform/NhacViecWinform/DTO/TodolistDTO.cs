using System;

namespace NhacViecWinform.DTO
{
    internal class TodolistDTO
    {
        private int id;
        private int workflow_id;
        private DateTime date_start;
        private DateTime date_reminder;
        private DateTime date_success;
        private string reason;
        private bool status;

        public int Id { get => id; set => id = value; }
        public int Workflow_id { get => workflow_id; set => workflow_id = value; }
        public DateTime Date_success { get => date_success; set => date_success = value; }
        public string Reason { get => reason; set => reason = value; }
        public bool Status { get => status; set => status = value; }
        public DateTime Date_reminder { get => date_reminder; set => date_reminder = value; }
        public DateTime Date_start { get => date_start; set => date_start = value; }
    }
}