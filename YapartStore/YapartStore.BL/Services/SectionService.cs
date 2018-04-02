using System;
using System.Linq;
using AutoMapper;
using YapartStore.BL.Entities;
using YapartStore.BL.Services.Base;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Entities;

namespace YapartStore.BL.Services
{
    public class SectionService : ISectionService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SectionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddItem(SectionDTO item)
        {
            try
            {
                var section = Mapper.Map<SectionDTO, Section>(item);
                _unitOfWork.SectionRepository.Create(section);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteItem(SectionDTO item)
        {
            try
            {
                var section = Mapper.Map<SectionDTO, Section>(item);
                var findSection = _unitOfWork.SectionRepository.GetAll().FirstOrDefault(gr => gr.Name == item.Name);
                if (findSection != null)
                {
                    _unitOfWork.GroupRepository.Delete(findSection.Id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<SectionDTO> GetAll()
        {
            try
            {
                var sections = Mapper.Map<IQueryable<Section>, IQueryable<SectionDTO>>(_unitOfWork.SectionRepository.GetAll());
                if (sections != null)
                    return sections;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SectionDTO GetItemById(int id)
        {
            try
            {
                var section = _unitOfWork.SectionRepository.GetAll().FirstOrDefault(sec => sec.Id == id);
                if (section != null)
                    return Mapper.Map<Section, SectionDTO>(section);
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateItem(SectionDTO item)
        {
            var section = Mapper.Map<SectionDTO, Section>(item);
            _unitOfWork.SectionRepository.Update(section);
        }
    }
}
