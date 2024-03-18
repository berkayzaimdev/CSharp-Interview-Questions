using System;


class Program
{
    public class MainWindow
    {
        public event EventHandler<EventArgs> mainWindowEventHandler;

        private void buttonClick_OpenChildWindow(object sender, EventArgs e)
        {
            var childWindow = new ChildWindow(this);
            childWindow.Show();
        }
    }

    public class ChildWindow
    {
        private MainWindow _mainApplicationWindow;

        public ChildWindow(MainWindow mainApplicationWindow)
        {
            _mainApplicationWindow = mainApplicationWindow;
            _mainApplicationWindow.mainWindowEventHandler += HandleEventFromMainWindowInChildWindow;
        }

        private void HandleEventFromMainWindowInChildWindow(object sender, EventArgs e)
        {
        }

        internal void Show()
        {
            //opening a window
        }

        void OnWindowClosing()
        {
            _mainApplicationWindow.mainWindowEventHandler -= HandleEventFromMainWindowInChildWindow;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}
/*
 * Garbage Collector, C# diline dahili olarak gelen bir bellek temizleme mekanizmasıdır.
 * GC, Heap'te bulunan verilerle ilgilenir; bu verileri bellekten gerekli durumlarda temizler.
 * 
 * GC, belleği ne zaman temizler?
 *    - Düşük fiziksel hafızaya ulaşıldığında, işletim sistemi CLR'ı bilgilendirir ve GC çalışır
 *    - GC.Collect methodu çağrıldığında
 *    - Hafızayı kullanan objeler belirtilen şartı aştığında
 *    
 * GC, çalıştığın an tüm thread'leri dondurur!
 *    - C# ile yazılmış bir oyun hayal edelim. Bu oyunda sürekli nesneler oluşturulup kısa süre sonra yok edilsin. Böyle bir mimaride GC thread'ı sürekli koşacağı için sıkça diğer thread'leri dondurmak durumunda kalır. Böyle bir mimari kullanılmamalıdır.
 *    
 * GC, memory leak'ten %100 koruma garantisi vermez. Memory leak, hafızada yer kaplayan nesne kullanılmasa bile o hafızanın temizlenememesidir.
 * Memory leak'in en önemli nedenlerinden biri EventHandler'lardır.
 * 
 */
