using GeneratorNickName.Core.Services;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorNickName.Core.ViewModels
{
    public class GeneratorViewModel : MvxViewModel
    {
        private readonly IGeneratorService _generatorService;
        private string _name;
        private int _favNumber;
        private string _nickName;

        public GeneratorViewModel(IGeneratorService generatorService)
        {
            _generatorService = generatorService;
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged(() => Name);
                Generate();
            }
        }

        public int FavoriteNumber
        {
            get => _favNumber;
            set
            {
                _favNumber = value;
                RaisePropertyChanged(() => FavoriteNumber);
                Generate();
            }
        }

        public string NickName
        {
            get => _nickName;
            set
            {
                _nickName = value;
                RaisePropertyChanged(() => NickName);
            }
        }

        public async override Task Initialize()
        {
            await base.Initialize();
            Name = "Anyone";
            FavoriteNumber = 2;
            Generate();
        }

        private void Generate()
        {
            NickName = _generatorService.GenerateNickName(Name.ToLower(), FavoriteNumber);
        }
    }
}
