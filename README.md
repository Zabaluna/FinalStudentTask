 # Итоговая проверочная работа
 ## Задача
 Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
 ## Алгоритм решения задачи:
 * Создаем первый массив и вносим в него наши данные. Заполняем сами
 * Выводим значение массива на экран
 * Создаем второй наш массив, который будет заполняться по условию задачи
 * Важно, наши массивы имеют одинаковую длину
 * Дальше используем метод, в котором используем перемнную count для второго массива 
 * Создаем цикл *for*. В нем задаем цикл *if*. Проверяем условие задачи, если нужная нам строка меньше или равна трем, то кладем ее в *count*
 * Следующий раз *count* уже увеличивается на единицу, проверка идет дальше 
 * Так мы поочередно проверяем все строки из первого массива от первого элемента до последнего
 * В конце через медод *Console.Write* выводим в консоль значения удовлетворяющие условию задачи
 * Ура! 