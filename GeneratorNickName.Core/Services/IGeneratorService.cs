using System;
using System.Collections.Generic;
using System.Text;

namespace GeneratorNickName.Core.Services
{
    public interface IGeneratorService
    {
        string GenerateNickName(string name, int favNumber);

    }
}
