using Domain_Layer.Models;
using Repository_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer
{
    public class FilesService <T> : IFilesService<Files> where T : class
    {
        private readonly IRepository<Files> iRepository;

        public FilesService(IRepository<Files> iRepository)
        {
            this.iRepository = iRepository;
        }

        public async Task Delete(long id)
        {
            Files entity = await iRepository.Get(id);
            iRepository.Remove(entity);
            await iRepository.SaveChanges();
        }

        public async Task<Files> Get(long id)
        {
            return await iRepository.Get(id);
        }

        public IEnumerable<Files> GetAll()
        {
            return iRepository.GetAll();
        }

        public async Task Insert(Files entity)
        {
            await iRepository.Insert(entity);
        }

        public async Task Update(Files entity)
        {
            await iRepository.Update(entity);
        }
    }
}
