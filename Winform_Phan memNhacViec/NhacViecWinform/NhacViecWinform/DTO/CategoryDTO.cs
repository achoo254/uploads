namespace NhacViecWinform.DTO
{
    internal class CategoryDTO
    {
        private int id;
        private string name;
        private string details;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Details { get => details; set => details = value; }
    }
}