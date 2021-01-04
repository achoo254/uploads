using NhacViecWinform.DAO;

namespace NhacViecWinform.BUS
{
    internal class CategoryBUS
    {
        private CategoryDAO CategoryDAO = new CategoryDAO();

        public object GetCategoryBUS()
        {
            return CategoryDAO.GetCategoryDAO();
        }

        public string SelectNameCategoryBUS(int category_id)
        {
            return CategoryDAO.SelectNameCategoryDAO(category_id);
        }
    }
}