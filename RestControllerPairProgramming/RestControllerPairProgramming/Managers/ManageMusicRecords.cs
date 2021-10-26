using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelLib.Model;

namespace RestControllerPairProgramming.Managers
{
    public class ManageMusicRecords : IManageMusicRecords
    {
        private static List<MusicRecords> musicRecordsList = new List<MusicRecords>()
        {

        };
        public IEnumerable<MusicRecords> Get()
        {
            throw new NotImplementedException();
        }

        public MusicRecords Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Create(MusicRecords value)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, MusicRecords value)
        {
            throw new NotImplementedException();
        }

        public MusicRecords Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
