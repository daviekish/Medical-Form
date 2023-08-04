using Domain_Layer.Models;
using Repository_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer
{
    public class UserService <T> : IUserService<MedicalFromModel> where T : class
    {
        private readonly IRepository<MedicalFromModel> iRepository;

        public UserService(IRepository<MedicalFromModel> iRepository)
        {
            this.iRepository = iRepository;
        }

        public async Task Delete(long id)
        {
            MedicalFromModel entity = await iRepository.Get(id);
            iRepository.Remove(entity);
            await iRepository.SaveChanges();
        }

        public async Task<MedicalFromModel> Get(long id)
        {
            return await iRepository.Get(id);
        }

        public IEnumerable<MedicalFromModel> GetAll()
        {
            return iRepository.GetAll();
        }

        public async Task Insert(MedicalFromModel entity)
        {
           await iRepository.Insert(entity);
        }

        public async Task Update(MedicalFromModel entity)
        {
            await iRepository.Update(entity);
        }
    }
}
