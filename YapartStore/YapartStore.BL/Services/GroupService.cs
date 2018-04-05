using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using YapartStore.BL.Entities;
using YapartStore.BL.Services.Base;
using YapartStore.DAL.Repositories.Base;
using YapartStore.DL.Entities;

namespace YapartStore.BL.Services
{
    public class GroupService : IGroupService
    {
        private readonly IUnitOfWork _unitOfWork;

        public GroupService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddItem(GroupDTO item)
        {
            try
            {
                var group = Mapper.Map<GroupDTO, Group>(item);
                _unitOfWork.GroupRepository.Create(group);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteItem(GroupDTO item)
        {
            try
            {
                var group = Mapper.Map<GroupDTO, Group>(item);
                var findGroup = _unitOfWork.GroupRepository.GetAll().FirstOrDefault(gr => gr.Name == item.Name);
                if (findGroup != null)
                {
                    _unitOfWork.GroupRepository.Delete(findGroup.Id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteItem(string groupName)
        {
            try
            {
                var findGroup = _unitOfWork.GroupRepository.GetAll().FirstOrDefault(gr => gr.Name == groupName);
                if (findGroup != null)
                {
                    _unitOfWork.GroupRepository.Delete(findGroup.Id);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<GroupDTO> GetAll()
        {
            try
            {
                var groups = Mapper.Map<IQueryable<Group>, IList<GroupDTO>>(_unitOfWork.GroupRepository.GetAll());
                if (groups != null)
                    return groups;
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public GroupDTO GetItemById(int id)
        {
            try
            {
                var group = _unitOfWork.GroupRepository.GetAll().FirstOrDefault(gr => gr.Id == id);
                if (group != null)
                    return Mapper.Map<Group, GroupDTO>(group);
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateItem(GroupDTO item)
        {
            throw new System.NotImplementedException();
        }
    }
}
