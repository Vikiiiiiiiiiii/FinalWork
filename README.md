# FinalWork

**_Алгоритм решения:_**

1. Пользователь задал массив **размером в 4 элемента**.
2. Массив заполняется **рандомными числами** от 10 до 50.
3. Печатаем массив.

**_Так как мы не можем в нашем изначальном массиве просто уменьшить его размерность, нам необходимо будет удалить один из его элементов_**. Решение будет следующим:

4. Задаём функцию в которой тип возвращаемого значения будет *void*. Название нашего метода *NewArray* и принимаемые параметры: наш массив и индекс того элемента, который мы хотим **удалить** из нашего массива. Для этого сделаем так:
* создаём **_новый массив_** и указываем, что в нём количество элементов на единицу меньше;
* в *array.Length* у нас лежит изначальное количество элементов массива и от него мы *отнимаем* единицу; 

5. Получаем количество элементов на 1 **_меньше_**.

**_Теперь наша задача в наш новый массив скопировать все элементы старого за исключением того элемента, который находится под индексом, который нам нужно удалить._** Сделаем с помощью циклов *for* :
* первый наш цикл *__for__* будет перебирать старый массив до тех пор пока мы не дойдём до элемента, который должны удалить;
* второй цикл *__for__* дописывает в наш новый массив все элементы из старого массива после элемента под индексом, который нам нужно *игнорировать*.

6. В наш *старый массив* мы присваиваем значение *нового массива*, в котором удалили элемент.
7. *__Вызываем наш метод__* и указываем индекс элемента, который удаляем. 

# Блок-схема

