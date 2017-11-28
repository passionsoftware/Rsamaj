using RS.DataAccessLayer;
using RS.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.BusinessLogicLayer
{
    public class GallaryBL
    {
        GallaryDL _gallaryDL;

        public GallaryBL()
        {
            _gallaryDL = new GallaryDL();
        }

        public int InsertGallary(GallaryModel obj)
        {
            int result = 0;
            result = _gallaryDL.InsertGallary(obj);
            return result;
        }

        public int UpdateGallary(GallaryModel obj)
        {
            int result = 0;
            result = _gallaryDL.UpdateGallary(obj);
            return result;
        }

        public int DeleteGallary(int id)
        {
            int result = 0;
            result = _gallaryDL.DeleteGallary(id);
            return result;
        }

        public List<GallaryModel> GetAllGallary()
        {
            List<GallaryModel> result = new List<GallaryModel>();
            result = _gallaryDL.GetAllGallary();
            return result;
        }

        public GallaryModel GetNewsId(int id)
        {
            GallaryModel result = new GallaryModel();
            result = _gallaryDL.GetGallaryId(id);
            return result;
        }
    }
}
