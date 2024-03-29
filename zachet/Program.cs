﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace zachet
{
    class Program
    {
        static void Main(string[] args)
        {
            var deps = new List<Department>(new[]
            {
                new Department("ДАДПРиФТ", new Prepod("Соловьев", "Владимир", "Игоревич", 1500)),
                new Department("ДЯП", new Prepod("Климова", "Ирина", "Иосифовна", 1500))
            });
            
            var firstNames = new[] { "Авдотья", "Агафья", "Аида", "Аким", "Аксинья", "Алёна", "Алевтина", "Александр", "Александра", "Алексей", "Алина", "Алла", "Анастасия", "Анатолий", "Ангелина", "Андрей", "Анисья", "Анна", "Антон", "Антонина", "Анфим", "Анфиса", "Аполлинария", "Арина", "Аркадий", "Арсений", "Артём", "Артемий", "Ася", "Аэлита", "Богдан", "Богдана", "Борис", "Борислав", "Вадим", "Валентин", "Валентина", "Валерий", "Валерия", "Варвара", "Василий", "Василина", "Василиса", "Венера", "Вера", "Вета", "Виктор", "Викторина", "Виктория", "Вилена", "Виталий", "Виталина (Виталия)", "Влад", "Влада", "Владана", "Владимир", "Владислав", "Владислава", "Владлен", "Влас", "Всеволод", "Вячеслав", "Гавриил", "Галина", "Геннадий", "Георгий", "Герасим", "Глафира", "Глеб", "Гордей", "Григорий", "Дамир", "Даниил", "Данил", "Данислав", "Дарья", "Демид", "Демьян", "Денис", "Джереми (Иеремия)", "Дина", "Дмитрий", "Домника", "Евгений", "Евгения", "Евдоким", "Евдокия", "Евстахий", "Егор", "Екатерина", "Елена", "Елизавета", "Елисей", "Емельян", "Еремей", "Есения", "Ефим", "Захар", "Зинаида", "Зиновий", "Злата", "Зоя", "Иван", "Игнат", "Игнатий", "Игорь", "Иероним (Джером)", "Изабелла", "Илина", "Иллирика", "Илья", "Инесса", "Инна", "Иннокентий", "Иоанна", "Ира", "Ираида", "Ирина", "Искра", "Ия", "Карина", "Кира", "Кирилл", "Клим", "Константин", "Кристина", "Ксения", "Кузьма", "Лада", "Лара", "Лариса", "Лев", "Леонид", "Лера", "Лидия", "Лика", "Лина", "Лукерья", "Любовь", "Людмила", "Ляля", "Магдалeна", "Майя", "Макар", "Макарий", "Макария", "Максим", "Маргарита", "Марина", "Мария", "Марк", "Мартин (Мартын)", "Марфа", "Матвей", "Мила", "Милада", "Милана", "Милена", "Милица", "Мира", "Мирослав", "Мирослава", "Мирра", "Михаил", "Надежда", "Наталья", "Нелли", "Ника", "Никита", "Никодим", "Никола", "Николай", "Нина", "Нинель", "Оксана", "Октябрина", "Олег", "Олеся", "Ольга", "Осип (Иосиф)", "Остап", "Пётр", "Павел", "Павлина", "Пелагея", "Платон", "Платонида", "Полина", "Потап", "Прасковья", "Прохор", "Рада", "Радий", "Радик", "Радомир", "Радослав", "Раиса", "Рената", "Римма", "Ринат (Ренат)", "Родион", "Роман", "Ростислав", "Русалина", "Руслан", "Руслана", "Сабина", "Савва", "Савелий", "Светлана", "Святослав", "Севастьян", "Семён", "Серафима", "Сергей", "Сидор", "Соня", "Софья", "Спартак", "Станислав", "Стелла", "Степан", "Таисия", "Тарас", "Татьяна", "Таяна", "Тимофей", "Тихон", "Трофим", "Ульяна", "Устинья", "Фёдор", "Фаина", "Федора", "Федот", "Филипп", "Флор", "Фома", "Харитон", "Цагана", "Цветана", "Юлиан", "Юлия", "Юния", "Юрий", "Яков", "Яна", "Янина", "Ярина", "Ярослав", "Ярослава"};
            var lastNames = new[] { "Иванов", "Смирнов", "Кузнецов", "Попов", "Васильев", "Петров", "Соколов", "Михайлов", "Новиков", "Федоров", "Морозов", "Волков", "Алексеев", "Лебедев", "Семенов", "Егоров", "Павлов", "Козлов", "Степанов", "Николаев", "Орлов", "Андреев", "Макаров", "Никитин", "Захаров", "Зайцев", "Соловьев", "Борисов", "Яковлев", "Григорьев", "Романов", "Воробьев", "Сергеев", "Кузьмин", "Фролов", "Александров", "Дмитриев", "Королев", "Гусев", "Киселев", "Ильин", "Максимов", "Поляков", "Сорокин", "Виноградов", "Ковалев", "Белов", "Медведев", "Антонов", "Тарасов", "Жуков", "Баранов", "Филиппов", "Комаров", "Давыдов", "Беляев", "Герасимов", "Богданов", "Осипов", "Сидоров", "Матвеев", "Титов", "Марков", "Миронов", "Крылов", "Куликов", "Карпов", "Власов", "Мельников", "Денисов", "Гаврилов", "Тихонов", "Казаков", "Афанасьев", "Данилов", "Савельев", "Тимофеев", "Фомин", "Чернов", "Абрамов", "Мартынов", "Ефимов", "Федотов", "Щербаков", "Назаров", "Калинин", "Исаев", "Чернышев", "Быков", "Маслов", "Родионов", "Коновалов", "Лазарев", "Воронин", "Климов", "Филатов", "Пономарев", "Голубев", "Кудрявцев", "Прохоров", "Наумов", "Потапов", "Журавлев", "Овчинников", "Трофимов", "Леонов", "Соболев", "Ермаков", "Колесников", "Гончаров", "Емельянов", "Никифоров", "Грачев", "Котов", "Гришин", "Ефремов", "Архипов", "Громов", "Кириллов", "Малышев", "Панов", "Моисеев", "Румянцев", "Акимов", "Кондратьев", "Бирюков", "Горбунов", "Анисимов", "Еремин", "Тихомиров", "Галкин", "Лукьянов", "Михеев", "Скворцов", "Юдин", "Белоусов", "Нестеров", "Симонов", "Прокофьев", "Харитонов", "Князев", "Цветков", "Левин", "Митрофанов", "Воронов", "Аксенов", "Софронов", "Мальцев", "Логинов", "Горшков", "Савин", "Краснов", "Майоров", "Демидов", "Елисеев", "Рыбаков", "Сафонов", "Плотников", "Демин", "Хохлов", "Фадеев", "Молчанов", "Игнатов", "Литвинов", "Ершов", "Ушаков", "Дементьев", "Рябов", "Мухин", "Калашников", "Леонтьев", "Лобанов", "Кузин", "Корнеев", "Евдокимов", "Бородин", "Платонов", "Некрасов", "Балашов", "Бобров", "Жданов", "Блинов", "Игнатьев", "Коротков", "Муравьев", "Крюков", "Беляков", "Богомолов", "Дроздов", "Лавров", "Зуев", "Петухов", "Ларин", "Никулин", "Серов", "Терентьев", "Зотов", "Устинов", "Фокин", "Самойлов", "Константинов", "Сахаров", "Шишкин", "Самсонов", "Черкасов", "Чистяков", "Носов", "Спиридонов", "Карасев", "Авдеев", "Воронцов", "Зверев", "Владимиров", "Селезнев", "Нечаев", "Кудряшов", "Седов", "Фирсов", "Андрианов", "Панин", "Головин", "Терехов", "Ульянов", "Шестаков", "Агеев", "Никонов", "Селиванов", "Баженов", "Гордеев", "Кожевников", "Пахомов", "Зимин", "Костин", "Широков", "Филимонов", "Ларионов", "Овсянников", "Сазонов", "Суворов", "Нефедов", "Корнилов", "Любимов", "Львов", "Горбачев", "Копылов", "Лукин", "Токарев", "Кулешов", "Шилов", "Большаков", "Панкратов", "Родин", "Шаповалов", "Покровский", "Бочаров", "Никольский", "Маркин", "Горелов", "Агафонов", "Березин", "Ермолаев", "Зубков", "Куприянов", "Трифонов", "Масленников", "Круглов", "Третьяков", "Колосов", "Рожков", "Артамонов", "Шмелев", "Лаптев", "Лапшин", "Федосеев", "Зиновьев", "Зорин", "Уткин", "Столяров", "Зубов", "Ткачев", "Дорофеев", "Антипов", "Завьялов", "Свиридов", "Золотарев", "Кулаков", "Мещеряков", "Макеев", "Дьяконов", "Гуляев", "Петровский", "Бондарев", "Поздняков", "Панфилов", "Кочетков", "Суханов", "Рыжов", "Старостин", "Калмыков", "Колесов", "Золотов", "Кравцов", "Субботин", "Шубин", "Щукин", "Лосев", "Винокуров", "Лапин", "Парфенов", "Исаков", "Голованов", "Коровин", "Розанов", "Артемов", "Козырев", "Русаков", "Алешин", "Крючков", "Булгаков", "Кошелев", "Сычев", "Синицын", "Черных", "Рогов", "Кононов", "Лаврентьев", "Евсеев", "Пименов", "Пантелеев", "Горячев", "Аникин", "Лопатин", "Рудаков", "Одинцов", "Серебряков", "Панков", "Дегтярев", "Орехов", "Царев", "Шувалов", "Кондрашов", "Горюнов", "Дубровин", "Голиков", "Курочкин", "Латышев", "Севастьянов", "Вавилов", "Ерофеев", "Сальников", "Клюев", "Носков", "Озеров", "Кольцов", "Комиссаров", "Меркулов", "Киреев", "Хомяков", "Булатов", "Ананьев", "Буров", "Шапошников", "Дружинин", "Островский", "Шевелев", "Долгов", "Суслов", "Шевцов", "Пастухов", "Рубцов", "Бычков", "Глебов", "Ильинский", "Успенский", "Дьяков", "Кочетов", "Вишневский", "Высоцкий", "Глухов", "Дубов", "Бессонов", "Ситников", "Астафьев", "Мешков", "Шаров", "Яшин", "Козловский", "Туманов", "Басов", "Корчагин", "Болдырев", "Олейников", "Чумаков", "Фомичев", "Губанов", "Дубинин", "Шульгин", "Касаткин", "Пирогов", "Семин", "Трошин", "Горохов", "Стариков", "Щеглов", "Фетисов", "Колпаков", "Чесноков", "Зыков", "Верещагин", "Минаев", "Руднев", "Троицкий", "Окулов", "Ширяев", "Малинин", "Черепанов", "Измайлов", "Алехин", "Зеленин", "Касьянов", "Пугачев", "Павловский", "Чижов", "Кондратов", "Воронков", "Капустин", "Сотников", "Демьянов", "Косарев", "Беликов", "Сухарев", "Белкин", "Беспалов", "Кулагин", "Савицкий", "Жаров", "Хромов", "Еремеев", "Карташов", "Астахов", "Русанов", "Сухов", "Вешняков", "Волошин", "Козин", "Худяков", "Жилин", "Малахов", "Сизов", "Ежов", "Толкачев", "Анохин", "Вдовин", "Бабушкин", "Усов", "Лыков", "Горлов", "Коршунов", "Маркелов", "Постников", "Черный", "Дорохов", "Свешников", "Гущин", "Калугин", "Блохин", "Сурков", "Кочергин", "Греков", "Казанцев", "Швецов", "Ермилов", "Парамонов", "Агапов", "Минин", "Корнев", "Черняев", "Гуров", "Ермолов", "Сомов", "Добрынин", "Барсуков", "Глушков", "Чеботарев", "Москвин", "Уваров", "Безруков", "Муратов", "Раков", "Снегирев", "Гладков", "Злобин", "Моргунов", "Поликарпов", "Рябинин", "Судаков", "Кукушкин", "Калачев", "Грибов", "Елизаров", "Звягинцев", "Корольков", "Федосов" };
            var midNames = new[] { "Александрович", "Алексеевич", "Анатольевич", "Андреевич", "Антонович", "Аркадьевич", "Артемович", "Бедросович", "Богданович", "Борисович", "Валентинович", "Валерьевич", "Васильевич", "Викторович", "Витальевич", "Владимирович", "Владиславович", "Вольфович", "Вячеславович", "Геннадиевич", "Георгиевич", "Григорьевич", "Данилович", "Денисович", "Дмитриевич", "Евгеньевич", "Егорович", "Ефимович", "Иванович", "Иваныч", "Игнатьевич", "Игоревич", "Ильич", "Иосифович", "Исаакович", "Кириллович", "Константинович", "Леонидович", "Львович", "Максимович", "Матвеевич", "Михайлович", "Николаевич", "Олегович", "Павлович", "Палыч", "Петрович", "Платонович", "Робертович", "Романович", "Саныч", "Северинович", "Семенович", "Сергеевич", "Станиславович", "Степанович", "Тарасович", "Тимофеевич", "Федорович", "Феликсович", "Филиппович", "Эдуардович", "Юрьевич", "Яковлевич", "Ярославович" };
            var disciplines = new[] { new[] {"C#", "Unix", "БИС", "Excel", "Анализ данных"}, new[] {"Английский язык", "Испанский язык", "Французский язык", "Немецкий язык"}};
            
            var rnd = new Random(17);
            
            for (var j = 0; j < 2; j++)
            {
                for (var i = 0; i < 5; i++)
                {
                    var first = firstNames[rnd.Next(firstNames.Length)];
                    var mid = midNames[rnd.Next(midNames.Length)];
                    var last = lastNames[rnd.Next(lastNames.Length)];
                    var sal = rnd.Next(500, 2000);
                    var disc = new List<string>();
                    disc.Add(disciplines[j][rnd.Next(disciplines[j].Length)]);
                    deps[j].Prepods.Add(new Prepod(last, first, mid, sal, disc));
                }
            }

            foreach (var dep in deps)
            {
                Console.WriteLine("-----------------------------------------------------------------------\n");
                Console.WriteLine(dep);
            }
        }
    }

    class Department
    {
        public List<Prepod> Prepods { get; }
        private string Name { get; }
        private Prepod Head { get; }

        public Department(string name, Prepod head)
        {
            Name = name;
            Prepods = new List<Prepod>();
            Head = head;
        }

        public Department(string name, Prepod head, List<Prepod> prepods)
        {
            Name = name;
            Head = head;
            Prepods = prepods;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Кафедра {Name}. Зав кафедрой: {Head}.");
            if (Prepods.Count > 0)
                sb.Append("Преподаватели:\n").Append(string.Join("\n", Prepods));
            return sb.ToString();
        }

        public Prepod FindMinSalary()
        {
            var min = int.MaxValue;
            Prepod minPr = null;
            foreach (var prepod in Prepods)
            {
                if (prepod.Salary >= min) continue;
                min = prepod.Salary;
                minPr = prepod;
            }

            return minPr;
        }

        public string FindPrepodsInAb(int a, int b)
        {
            var prepodsInAb = Prepods.Where(prepod => a < prepod.Salary && prepod.Salary < b).ToList();

            return prepodsInAb.Count > 0 ? string.Join(", ", prepodsInAb) : "Таких преподавателей нет";
        }
    }
    
    class Prepod
    {
        private string LastName { get; set; }
        private string FirstName { get; set; }
        private string Отчество { get; set; }
        private List<string> Disciplines { get; set; }
        public int Salary { get; set; }

        public Prepod(string lastName, string firstName, string отчество, int salary)
        {
            LastName = lastName;
            FirstName = firstName;
            Отчество = отчество;
            Disciplines = new List<string>();
            Salary = salary;
        }

        public Prepod(string lastName, string firstName, string отчество, int salary, List<string> disciplines)
        {
            LastName = lastName;
            FirstName = firstName;
            Отчество = отчество;
            Disciplines = disciplines;
            Salary = salary;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{LastName} {FirstName} {Отчество}");
            if (Disciplines.Count > 0)
                sb.Append(", преподаватель дисциплин: ").Append(string.Join(", ", Disciplines));
            sb.Append($"\nЗарплата: {Salary}");
            return sb.ToString();
        }
    }
}