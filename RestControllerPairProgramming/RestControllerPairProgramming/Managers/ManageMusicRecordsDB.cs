using ModelLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestControllerPairProgramming.Managers
{
    public class ManageMusicRecordsDB : IManageMusicRecords
    {
        private readonly MusicRecordsContext _context;

        public ManageMusicRecordsDB(MusicRecordsContext context)
        {
            _context = context;
        }
        public bool Create(MusicRecords value)
        {
            throw new NotImplementedException();
        }

        public MusicRecords Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MusicRecords> Get()
        {
            return _context.MusicRecords;
        }

        public MusicRecords Get(int id)
        {
            return _context.MusicRecords.Find(id);
        }

        public bool Update(int id, MusicRecords value)
        {
            throw new NotImplementedException();
        }
    }
}
