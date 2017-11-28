using RS.DataAccessLayer;
using RS.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.BusinessLogicLayer
{
    public class AlbumBL
    {
        AlbumDL _albumBL;

        public AlbumBL()
        {
            _albumBL = new AlbumDL();
        }

        public int InsertAlbum(AlbumModel obj)
        {
            int result = 0;
            result = _albumBL.InsertAlbum(obj);
            return result;
        }

        public int UpdateAlbum(AlbumModel obj)
        {
            int result = 0;
            result = _albumBL.UpdateAlbum(obj);
            return result;
        }

        public int DeleteAlbum(int id)
        {
            int result = 0;
            result = _albumBL.DeleteAlbum(id);
            return result;
        }

        public List<AlbumModel> GetAllAlbum()
        {
            List<AlbumModel> result = new List<AlbumModel>();
            result = _albumBL.GetAllAlbum();
            return result;
        }

        public AlbumModel GetAlbumId(int id)
        {
            AlbumModel result = new AlbumModel();
            result = _albumBL.GetAlbumId(id);
            return result;
        }
    }
}
