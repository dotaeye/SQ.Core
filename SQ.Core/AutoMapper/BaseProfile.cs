using AutoMapper;

namespace SQ.Core.AutoMapper
{
    public abstract class BaseProfile : Profile
    {
        private readonly string _profileName;

        protected BaseProfile(string profileName)
        {
            _profileName = profileName;
        }

        public override string ProfileName
        {
            get { return _profileName; }
        }

        protected override void Configure()
        {
            CreateMaps();
        }

        protected abstract void CreateMaps();
    }
}
