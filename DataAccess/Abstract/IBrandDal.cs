using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract;

public interface IBrandDal
{
    void add(Brand brand);
    List<Brand> GetAll();

}
