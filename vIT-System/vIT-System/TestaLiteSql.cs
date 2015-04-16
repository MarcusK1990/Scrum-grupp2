using System.Linq;

namespace vIT_System
{
    public static class TestaLiteSql
    {
        public static Anstallda Q1()
        {
            using (var context = new vITsEntities())
            {
                
            return context.Anstallda.FirstOrDefault(x => x.Id == 1);
            }
        


        }
    }
}
