# WPF_Lessons
 Решение задач на уроках по курсу "WPF on C#"

 [Набор_кнопок](https://github.com/nomadpyn/WPF_Lessons/tree/master/l1_button_set)

  Разработать приложение содержащее набор кнопок, занимающих 2/3 ширины окна при любых его размерах. Каждая кнопка должна в качестве содержимого отображать название цвета и обладать наружным отступом равным 2. Также соответствующий цвет должен использоваться в качестве цвета переднего плана кнопки. Необходимо использовать следующий набор цветов: Navy, Blue, Aqua, Teal, Olive, Green, Lime, Yellow, Orange, Red, Maroon, Fuchsia, Purple, Black, Silver, Gray, White. Также при нажатию на кнопку, цвет формы должен меняться на выбранный, а в заголовке было бы написано "Теперь цвет формы Navy".

 [Калькулятор](https://github.com/nomadpyn/WPF_Lessons/tree/master/l2_calculator)

  Разработать приложение "Калькулятор". В верхней части приложения необходимо использовать два поля для ввода текста. Первое используется для отображения предыдущих операций, второе - для ввода текущего числа. Оба поля должны запрещать редактировать свое содержимое посредством клавиатурного ввода. Данные поля будут заполняться автоматически при нажатии на соответствующие кнопки, расположенные ниже. Кнопки "0-9" добавляют соответствующую цифру в конец текущего числа. При этом должны выполняться проверки, не допускающие неправильного ввода. Например, нельзя вводить числа, начинающиеся с ноля, после которого нет десятичной точки. Кнопка "." добавляет (если это возможно) десятичную точку в текущее число. Кнопки " * / + - " выполняют соответствующую операцию над результатом предыдущей операции и текущим числом. Кнопка "=" вычисляет выражение и выводит результат. Кнопка "CE" очищает текущее число. Кнопка "C" очищает текущее число и предыдущее выражение. Кнопка "Del" очищает последний введенный символ в текущем числе.

 [Список_покупок](https://github.com/nomadpyn/WPF_Lessons/tree/master/l3_shopping_list)

  Разработать приложение, для отображения списка покупок. Для удобства хранения данных требуется создать класс Товар, в котором будет храниться информации о данных о товаре. Список покупок формируется в DataGrid, которое содержит три колонки: товар, количество и куплен (да/нет). Для хранения данных использовать рекомендуется BindigList. При открытие программы, данные о списке покупок загружаются из файла в корне программы. При закрытии окна, данные сохраняются в файл, при этом только те, которые помечены как не купленные. Для сохранения данных в файл рекомендуется использовать JSON.

 [Окно_регистрации](https://github.com/nomadpyn/WPF_Lessons/tree/master/l4_reg_window)

  Создать приложение для регистрации поля в фиксированном окне, которое представляет ввод имени, ввод пароля и его проверка, ввод электронной почты и кнопка "Зарегистироваться". При нажатии на кнопку происходит проверка имени на длину (не менее 4 символов), пароль (не менее 6), проверка пароля, и проверка электронной почты (@ и .ru). При иерархической проверке выдавать Tip что не так и выделять поле красным цветом. Если пользователь с таким именнем существует, то выдать сообщение об этом. Пользователей хранить в выбранной вами коллекции в файле на усмотрение (bin, xml или json).

 [Викторина](https://github.com/nomadpyn/WPF_Lessons/tree/master/l5_quiz)

  Создать приложение викторина на любую тему на 5-7 вопросов. В окне должен отображаться вопрос с изображением для информативности и 3-4 четыре варианта ответа. Кнопки для ответа обычные или RadioButton, на усмотрение разработчика. Вопросы "раскидать" по вкладкам, используя TabControl.Для удобства сделать ProgressBar, который отображает, на сколько вопросов ответили, и когда он полный разблокирует кнопку "Закончить". При нажатии на кнопку "Закончить" происходит подсчет очков и выходит сообщение с рейтингом. Рейтинг представляет градацию: плохо знает, хорошо знает, отлично знает. 