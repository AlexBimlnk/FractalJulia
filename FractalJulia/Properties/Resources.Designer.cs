﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FractalJulia.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FractalJulia.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на ------Помощь по программе------
        ///Меню:
        ///	Помощь -&gt; открывает файл помощи.
        ///
        ///	Сохранить -&gt; сохранить изображение, полученное на экране.
        ///
        ///
        ///Настройки:
        ///	Отмена -&gt; отмена действия, возвращает предыдущую картинку (макс. возвратов - 2).
        ///
        ///	Цикл -&gt; Предоставляет возможность пользователю задать диапазон значение Z
        ///		которые будут использоваться для получения изображений (подробнее в разделе &quot;Как пользоваться?&quot;).
        ///
        ///	Создать анимацию -&gt; создает анимированную картинку (gif) из изображений (подробнее в разделе &quot; [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string Help {
            get {
                return ResourceManager.GetString("Help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на ------Примеры числа Z------
        /////Здесь будут дани числа, с которыми получаются красивые множества.
        ///
        ///1) zRe = -0.70176; zIm = -0.3842;
        ///
        ///2) zRe = -0.74543; zIm = 0.11301;
        ///
        ///3) zRe = -0.8; zIm = 0.156;
        ///
        ///4) zRe = 0.3; zIm = -0.0262;
        ///
        ///5) zRe = -1; zIm = 0;
        ///
        ///6) zRe = -0.07; zIm = 0.66;
        ///
        ///7) zRe = -0.08; zIm = 0.83;
        ///
        ///8) zRe = -0.70176; zIm = -0.3842;.
        /// </summary>
        internal static string NumbersZ {
            get {
                return ResourceManager.GetString("NumbersZ", resourceCulture);
            }
        }
    }
}
