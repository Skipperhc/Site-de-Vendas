using System.Collections.Generic;

namespace site_de_vendas.Repositories.Interface {
    public interface IRepository<T> {
        T Buscar(int id);
        void Adicionar(T entidade);
        void Remover(T entidade);
        List<T> Listar();
        void Editar(T entidade);
    }
}