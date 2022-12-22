# WPF_Lessons
 Решение задач на уроках по курсу "WPF on C#"

 [Набор_кнопок](https://github.com/nomadpyn/WPF_Lessons/tree/master/l1_button_set)

  Разработать приложение содержащее набор кнопок, занимающих 2/3 ширины окна при любых его размерах. Каждая кнопка должна в качестве содержимого отображать название цвета и обладать наружным отступом равным 2. Также соответствующий цвет должен использоваться в качестве цвета переднего плана кнопки. Необходимо использовать следующий набор цветов: Navy, Blue, Aqua, Teal, Olive, Green, Lime, Yellow, Orange, Red, Maroon, Fuchsia, Purple, Black, Silver, Gray, White. Также при нажатию на кнопку, цвет формы должен меняться на выбранный, а в заголовке было бы написано "Теперь цвет формы Navy".

 [Калькулятор](https://github.com/nomadpyn/WPF_Lessons/tree/master/l2_calculator)

  Разработать приложение "Калькулятор". В верхней части приложения необходимо использовать два поля для ввода текста. Первое используется для отображения предыдущих операций, второе - для ввода текущего числа. Оба поля должны запрещать редактировать свое содержимое посредством клавиатурного ввода. Данные поля будут заполняться автоматически при нажатии на соответствующие кнопки, расположенные ниже. Кнопки "0-9" добавляют соответствующую цифру в конец текущего числа. При этом должны выполняться проверки, не допускающие неправильного ввода. Например, нельзя вводить числа, начинающиеся с ноля, после которого нет десятичной точки. Кнопка "." добавляет (если это возможно) десятичную точку в текущее число. Кнопки " * / + - " выполняют соответствующую операцию над результатом предыдущей операции и текущим числом. Кнопка "=" вычисляет выражение и выводит результат. Кнопка "CE" очищает текущее число. Кнопка "C" очищает текущее число и предыдущее выражение. Кнопка "Del" очищает последний введенный символ в текущем числе.