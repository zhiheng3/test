using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace congcong.Models
{
    public interface IRepository<TModel> where TModel : class
    {
        /// <summary>
        /// 添加【继承类重写后才能正常使用】
        /// </summary>
        bool Add(TModel Tmodel);
        /// <summary>
        /// 更新【继承类重写后才能正常使用】
        /// </summary>
        bool Update(TModel Tmodel);
        /// <summary>
        /// 删除【继承类重写后才能正常使用】
        /// </summary>
        bool Delete(int Id);

        /// <summary>
        /// 查找指定值【继承类重写后才能正常使用】
        /// </summary>
        TModel Find(int Id);
    }
}
