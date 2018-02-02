using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceArrayWithObject.Refactoring
{
    /// <summary>
    /// 將陣列封裝到一個類別中
    /// </summary>
    public class BaseBallCourt
    {
        string[] _baseBallCourt;

        public BaseBallCourt(string[] baseballCourt)
        {
            this._baseBallCourt = baseballCourt;
        }

        public string Price {
            get
            {
                return _baseBallCourt[0];
            }
            set
            {
                 _baseBallCourt[0] = value;
            }
        }

        public string Boss
        {
            get
            {
                return _baseBallCourt[1];
            }
            set
            {
                _baseBallCourt[1] = value;
            }
        }

        public string BuildOn
        {
            get
            {
                return _baseBallCourt[2];
            }
            set
            {
                _baseBallCourt[2] = value;
            }
        }
    }
}
