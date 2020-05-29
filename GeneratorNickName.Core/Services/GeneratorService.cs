using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorNickName.Core.Services
{
    public class GeneratorService:IGeneratorService
    {
        public string GenerateNickName(string name, int favNumber)
        {
            Random random = new Random();
            string nickName="";
            while (nickName.Length < 6)
            {
                nickName+= name[random.Next(0, name.Length)];
                if (nickName.Length > 5)
                {
                    nickName += favNumber;
                }
            }
            
            return nickName;
        }
    }
}
