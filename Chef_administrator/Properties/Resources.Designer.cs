﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chef_administrator.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Chef_administrator.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Добавить.
        /// </summary>
        public static string Add {
            get {
                return ResourceManager.GetString("Add", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Добавление категории.
        /// </summary>
        public static string Add_category {
            get {
                return ResourceManager.GetString("Add category", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Добавить блюда.
        /// </summary>
        public static string Add_dishes {
            get {
                return ResourceManager.GetString("Add dishes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Добавить ингредиент.
        /// </summary>
        public static string Add_Ingredient {
            get {
                return ResourceManager.GetString("Add Ingredient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Добавление категории. Слева находится поле для ввода названия категрии. Снизу Кнопка категрии возвращает вас на форму категории, кнопка добавить добавляет категорию которую вы ввели если уже нет такой категрии, кнопка Меню возвращает вас на форму меню. Спарва внизу есть таблица с уже существующими категриями..
        /// </summary>
        public static string Adding_a_category__On_the_left_is_a_field_for_entering_the_name_of_the_category__Bottom_The_category_button_returns_you_to_the_category_form__the_add_button_adds_the_category_you_entered_if_there_is_no_such_category_already__the_Menu_button_returns_you_to_the_menu_form__At_the_bottom_there_is_a_table_with_already_existing_categories_ {
            get {
                return ResourceManager.GetString(@"Adding a category. On the left is a field for entering the name of the category. Bottom The category button returns you to the category form, the add button adds the category you entered if there is no such category already, the Menu button returns you to the menu form. At the bottom there is a table with already existing categories.", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Добавление блюда. В названии вы вводите название блюда которое вы хотите создать, в весе выв вводите вес блюда который создаете, цену вы указываете любую за блюда, в количестве вы указываете сколько вы хотите создать блюда. Потом вы выбираете категории к которой будет отноитсяя ваше блюдо, и в трех раскрывающихся списках вы выбираете ингредиенты из которых будет состоять ваше блюдо. Далее вы нажимаете добавить и оно добовляется если есть ингредиенты в противном случае вам выдаст сообщение. Кнопка Меню вы ид [остаток строки не уместился]&quot;;.
        /// </summary>
        public static string Adding_a_dish {
            get {
                return ResourceManager.GetString("Adding a dish", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Добавление ингредиента. В названии вы вводите название ингредиента которое вы хотите создать, в количестве вы указываете сколько вы хотите создать ингредиентов. Далее вы нажимаете добавить и оно добовляется если нет таких ингредиентов в противном случае вам выдаст сообщение. Кнопка Меню вы идете на форму меню. Справа есть таблица с ингредиентами что бы вам было легче выбрать нужные ингредиенты..
        /// </summary>
        public static string Adding_an_ingredient__In_the_name_you_enter_the_name_of_the_ingredient_you_want_to_create__in_the_quantity_you_specify_how_many_ingredients_you_want_to_create__Next__you_click_add_and_it_is_added_if_there_are_no_such_ingredients__otherwise_you_will_be_given_a_message__Menu_button_you_go_to_the_menu_form__On_the_right_there_is_a_table_with_ingredients_to_make_it_easier_for_you_to_choose_the_right_ingredients_ {
            get {
                return ResourceManager.GetString(@"Adding an ingredient. In the name you enter the name of the ingredient you want to create, in the quantity you specify how many ingredients you want to create. Next, you click add and it is added if there are no such ingredients, otherwise you will be given a message. Menu button you go to the menu form. On the right there is a table with ingredients to make it easier for you to choose the right ingredients.", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Авторизация.
        /// </summary>
        public static string Authorization {
            get {
                return ResourceManager.GetString("Authorization", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Авторизация. Пользователь заполняет поля валидными данными нажимает кнопку Войти. Слева вверху есть выбор языка русского и английского. При нажатии на Russian то будет выбран язык русский, если English то английский. Снизу слева есть кнопка Справка ну я думаю вы и сами понимаете для чего она раз вы уже сюда зашли..
        /// </summary>
        public static string Authorization__The_user_fills_in_the_fields_with_valid_data_and_presses_the_Login_button__At_the_top_left_there_is_a_choice_of_the_language_of_Russian_and_English__When_you_click_on_Russian__the_language_will_be_Russian__if_English_then_English__At_the_bottom_left_there_is_a_Help_button__well__I_think_you_yourself_understand_what_it_is_for_since_you_have_already_come_here_ {
            get {
                return ResourceManager.GetString(@"Authorization. The user fills in the fields with valid data and presses the Login button. At the top left there is a choice of the language of Russian and English. When you click on Russian, the language will be Russian, if English then English. At the bottom left there is a Help button, well, I think you yourself understand what it is for since you have already come here.", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Капуста.
        /// </summary>
        public static string Cabbage {
            get {
                return ResourceManager.GetString("Cabbage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Категории. Слева вы увидите таблицу со всеми созданными категориями. Справа кнопки. Кнопка добавить позволяет вам переходить на форму добавление ингредиента, кнопка удалить позволяет вам удалять ингредиенты в таблице, кнопка Меню позволят вам переходить на форму Меню..
        /// </summary>
        public static string Categories__On_the_left_you_will_see_a_table_with_all_the_created_categories__Buttons_on_the_right__The_add_button_allows_you_to_go_to_the_add_ingredient_form__the_delete_button_allows_you_to_delete_ingredients_in_the_table__the_Menu_button_allows_you_to_go_to_the_Menu_form_ {
            get {
                return ResourceManager.GetString(@"Categories. On the left you will see a table with all the created categories. Buttons on the right. The add button allows you to go to the add ingredient form, the delete button allows you to delete ingredients in the table, the Menu button allows you to go to the Menu form.", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Категории.
        /// </summary>
        public static string Category {
            get {
                return ResourceManager.GetString("Category", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Сыр.
        /// </summary>
        public static string Cheese {
            get {
                return ResourceManager.GetString("Cheese", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Удалить.
        /// </summary>
        public static string Delete {
            get {
                return ResourceManager.GetString("Delete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Блюда.
        /// </summary>
        public static string Dishes {
            get {
                return ResourceManager.GetString("Dishes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Блюда. Слева вы увидите таблицу со всеми созданными блюдами. Справа кнопки. Кнопка Сортировать по весу позволяет вам сортировать блюда по весу, кнопка добавить позволяет вам переходить на форму добавление блюда, кнопка удалить позволяет вам удалять блюда в таблице, кнопка Сортировка по цене позволяет вам сортировать блюда по цене, кнопка Меню позволят вам переходить на форму Меню, кнопка Экспорт позволяет вам экспортировать таблицу в ворд. Чуть ниже вы можете ввести название блюда и вам найдет такое блюдо е [остаток строки не уместился]&quot;;.
        /// </summary>
        public static string Dishes_text {
            get {
                return ResourceManager.GetString("Dishes_text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Войти.
        /// </summary>
        public static string Enter {
            get {
                return ResourceManager.GetString("Enter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Введите название.
        /// </summary>
        public static string Enter_the_title {
            get {
                return ResourceManager.GetString("Enter the title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Экспорт.
        /// </summary>
        public static string Export {
            get {
                return ResourceManager.GetString("Export", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Ингредиенты.
        /// </summary>
        public static string Ingredients {
            get {
                return ResourceManager.GetString("Ingredients", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Ингредиетны. Слева вы увидите таблицу со всеми созданными блюдами. Справа кнопки. Кнопка добавить позволяет вам переходить на форму добавление ингредиента, кнопка удалить позволяет вам удалять ингредиенты в таблице, кнопка Меню позволят вам переходить на форму Меню. Чуть ниже вы можете ввести название ингредиента и вам найдет такой ингредиент если оно есть в таблице..
        /// </summary>
        public static string Ingredients__On_the_left_you_will_see_a_table_with_all_created_dishes__Buttons_on_the_right__The_add_button_allows_you_to_go_to_the_add_ingredient_form__the_delete_button_allows_you_to_delete_ingredients_in_the_table__the_Menu_button_allows_you_to_go_to_the_Menu_form__A_little_lower_you_can_enter_the_name_of_the_ingredient_and_you_will_find_such_an_ingredient_if_it_is_in_the_table_ {
            get {
                return ResourceManager.GetString(@"Ingredients. On the left you will see a table with all created dishes. Buttons on the right. The add button allows you to go to the add ingredient form, the delete button allows you to delete ingredients in the table, the Menu button allows you to go to the Menu form. A little lower you can enter the name of the ingredient and you will find such an ingredient if it is in the table.", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Логин.
        /// </summary>
        public static string Login {
            get {
                return ResourceManager.GetString("Login", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Меню.
        /// </summary>
        public static string Menu {
            get {
                return ResourceManager.GetString("Menu", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Пароль.
        /// </summary>
        public static string Password {
            get {
                return ResourceManager.GetString("Password", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Идеальная Менюшка. В менюшке вы можете выбрать Блюда, Ингредиенты, Категории. При нажатии на кнопку Блюда вы перейдете на форму блюда, если на кнопку Ингредиенты то на форму Ингредиентов, если на кнопку Категории то на форму Категории..
        /// </summary>
        public static string Perfect_Menu__In_the_menu_you_can_choose_Dishes__Ingredients__Categories__When_you_click_on_the_Dishes_button__you_will_go_to_the_dish_form__if_on_the_Ingredients_button__then_on_the_Ingredients_form__if_on_the_Category_button__then_on_the_Category_form_ {
            get {
                return ResourceManager.GetString("Perfect Menu. In the menu you can choose Dishes, Ingredients, Categories. When yo" +
                        "u click on the Dishes button, you will go to the dish form, if on the Ingredient" +
                        "s button, then on the Ingredients form, if on the Category button, then on the C" +
                        "ategory form.", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Картошка.
        /// </summary>
        public static string Potatoes {
            get {
                return ResourceManager.GetString("Potatoes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Цена.
        /// </summary>
        public static string Price {
            get {
                return ResourceManager.GetString("Price", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Количество.
        /// </summary>
        public static string Quantity {
            get {
                return ResourceManager.GetString("Quantity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Справка.
        /// </summary>
        public static string Reference {
            get {
                return ResourceManager.GetString("Reference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Поиск.
        /// </summary>
        public static string Search {
            get {
                return ResourceManager.GetString("Search", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Поиск по названию.
        /// </summary>
        public static string Search_by_name {
            get {
                return ResourceManager.GetString("Search by name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Сортировка по цене.
        /// </summary>
        public static string Sort_by_price {
            get {
                return ResourceManager.GetString("Sort by price", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Сортировка по весу.
        /// </summary>
        public static string Sorted_by_weight {
            get {
                return ResourceManager.GetString("Sorted by weight", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Название.
        /// </summary>
        public static string Title {
            get {
                return ResourceManager.GetString("Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Помидор.
        /// </summary>
        public static string Tomato {
            get {
                return ResourceManager.GetString("Tomato", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Обновить.
        /// </summary>
        public static string Update {
            get {
                return ResourceManager.GetString("Update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Вес.
        /// </summary>
        public static string Weight {
            get {
                return ResourceManager.GetString("Weight", resourceCulture);
            }
        }
    }
}
