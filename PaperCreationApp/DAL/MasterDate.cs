using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MasterDate
    {
        public List<DB_SUBJECTs> GetSubjects()
        {
            using (var entity = new DB_PAPEREntities() )
            {
               return entity.DB_SUBJECTs.Where(x=> x.Status == true).ToList();
            }
        }

        public List<DB_CHAPTER> GetChapters(int id)
        {
            using (var entity = new DB_PAPEREntities())
            {
                return entity.DB_CHAPTER.Where(x => x.Status == true && x.SubjectId == id).ToList();
            }
        }

        public List<DB_SHORTQ> GetShortQ(int id)
        {
            using (var entity = new DB_PAPEREntities())
            {
                return entity.DB_SHORTQ.Where(x => x.Status == true && x.ChapterId == id).ToList();
            }
        }

        public List<DB_LONGQ> GetLongQ(int id)
        {
            using (var entity = new DB_PAPEREntities())
            {
                return entity.DB_LONGQ.Where(x => x.Status == true && x.ChapterId == id).ToList();
            }
        }

        public List<DB_MCQ> GetMCQQ(int id)
        {
            using (var entity = new DB_PAPEREntities())
            {
                return entity.DB_MCQ.Where(x => x.Status == true && x.ChapterId == id).ToList();
            }
        }

    }
}
