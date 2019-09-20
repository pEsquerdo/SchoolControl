using SchoolControl.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolControl.Services
{
    public interface IGenericService<TEntity> where TEntity : class, IGenericEntity
    {
        TEntity BuscarPorCodigo(int codigo);
        TEntity Inserir(TEntity model);
        TEntity Alterar(TEntity model);
        bool Excluir(TEntity model);
        bool Excluir(int codigo);
        IList<TEntity> Listar();
        IList<TEntity> Listar(Expression<Func<TEntity, bool>> filtro);
    }
}
