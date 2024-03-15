using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Paging;

public class Paginate<T>
{
    public Paginate()
    {
        Items = Array.Empty<T>();
    }

    public int Size { get; set; } // Sayfaki data sayısı
    public int Index { get; set; } // hangi sayfadayız? 0'dan başlar.
    public int Count { get; set; } // toplam kayıt sayısı
    public int Pages { get; set; } // toplam sayfa sayısı
    public IList<T> Items { get; set; } // Data
    public bool HasPrevious => Index > 0; // önceki sayfa var mı?
    public bool HasNext => Index + 1 < Pages; // sonraki sayfa var mı?
}

