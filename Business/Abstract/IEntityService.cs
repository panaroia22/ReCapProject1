using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEntityService<T>
    {
        IDataResult<List<T>> GetAll();

        IDataResult<T> GetBrandByBrandId(int id);

        IResult Add(T entity);

        IResult Delete(T entity);

        IResult Update(T entity);
    }
}
