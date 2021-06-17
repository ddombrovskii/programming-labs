# Лабораторная работа №2 «Списки»

## Часть 2. Двуcвязные циклические списки

Разработать классы *"Узел двусвязного циклического списка" и *"Двусвязный циклический список"* в виде Windows приложения.

1. О программе
2. Задание (через выпадающие меню)
    * Создание списка
    * Редактирование списка
        * Добавление элемента
            * В начало
            * В конец
            * В произвольную точку
        * Удаление элемента
            * В начале
            * В конце
            * В произвольной точке
    * Обработка списка в соответствии с заданием, при этом отобразить начальное и конечное состояния списка
3. Выход

Как и в первой работе, должна быть страница О программе ЗАДАНИЕ Выход(горизонтальный интерфейс).

В окне ЗАДАНИЕ должен быть горизонтальный интерфейс СОЗДАНИЕ списка РЕДАКТИРОВАНИЕ списка (с выпадающими меню ДОБАВЛЕНИЕ, УДАЛЕНИЕ, из которых выпадают меню в соответствии с тем, в какую точку списка производится вставка), ОБРАБОТКА списка (по заданию), РАЗРУШЕНИЕ списка. Мы придерживаемся стиля интерфейса Windows, пункты его меню не открыты сразу, а открываются только при обращении к ним.

Разработать СВОИ классы на базе классов *DoubleNode* и *CycleDoubleLinkedList*.

Не использовать заполнение элементов списка случайными значениями, вводить их с клавиатуры с контролем ввода.

Для визуализации списка использовать компонент ListBox, вывод списков производить в вертикальные поля.

При выполнении действий над списками массивы, в том числе, LIST, НЕ ИСПОЛЬЗОВАТЬ! Массив можно использовать ТОЛЬКО для инициализации информационных полей элементов списка при первоначальном создании списка из заданного числа элементов.