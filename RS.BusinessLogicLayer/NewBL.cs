using RS.DataAccessLayer;
using RS.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RS.BusinessLogicLayer
{
    public class NewBL
    {

        NewsDL _newsDL;

        public NewBL()
        {
            _newsDL = new NewsDL();
        }

        public int InsertNews(NewsModel obj)
        {
            int result = 0;
            result = _newsDL.InsertNews(obj);
            return result;
        }

        public int UpdateNews(NewsModel obj)
        {
            int result = 0;
            result = _newsDL.UpdateNews(obj);
            return result;
        }

        public int DeleteNews(int id)
        {
            int result = 0;
            result = _newsDL.DeleteNews(id);
            return result;
        }

        public List<NewsModel> GetAllNews()
        {
            List<NewsModel> result = new List<NewsModel>();
            result = _newsDL.GetAllNews();
            return result;
        }

        public NewsModel GetNewsId(int id)
        {
            NewsModel result = new NewsModel();
            result = _newsDL.GetNewsId(id);
            return result;
        }
    }
}
