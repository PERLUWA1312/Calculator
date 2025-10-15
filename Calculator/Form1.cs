using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        string currentInput = ""; /* Хранит текущие хранимые цифры */
        double result = 0; /* Хранит промежуточный или конечные результаты вычислений */
        string operation = ""; /* Хранит текущую математическую операцию */
        bool operationPending = false; /* Указывает, была ли выбрана операция и ожидается ли ввод второго числа */

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; /* Получаем конкретную нажатую кнопку из общего объекта sender */
            currentInput += button.Text; /* Добавляет цифру или символ к текущему вводимому числу */
            textBox1.Text = currentInput; /* Отображает текущий ввод пользователя в интерфейсе калькулятора */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; /* Получаем конкретную нажатую кнопку из общего объекта sender */
            currentInput += button.Text; /* Добавляет цифру или символ к текущему вводимому числу */
            textBox1.Text = currentInput; /* Отображает текущий ввод пользователя в интерфейсе калькулятора */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; /* Получаем конкретную нажатую кнопку из общего объекта sender */
            currentInput += button.Text; /* Добавляет цифру или символ к текущему вводимому числу */
            textBox1.Text = currentInput; /* Отображает текущий ввод пользователя в интерфейсе калькулятора */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; /* Получаем конкретную нажатую кнопку из общего объекта sender */
            currentInput += button.Text; /* Добавляет цифру или символ к текущему вводимому числу */
            textBox1.Text = currentInput; /* Отображает текущий ввод пользователя в интерфейсе калькулятора */
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; /* Получаем конкретную нажатую кнопку из общего объекта sender */
            currentInput += button.Text; /* Добавляет цифру или символ к текущему вводимому числу */
            textBox1.Text = currentInput; /* Отображает текущий ввод пользователя в интерфейсе калькулятора */
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; /* Получаем конкретную нажатую кнопку из общего объекта sender */
            currentInput += button.Text; /* Добавляет цифру или символ к текущему вводимому числу */
            textBox1.Text = currentInput; /* Отображает текущий ввод пользователя в интерфейсе калькулятора */
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; /* Получаем конкретную нажатую кнопку из общего объекта sender*/
            currentInput += button.Text; /* Добавляет цифру или символ к текущему вводимому числу */
            textBox1.Text = currentInput; /* Отображает текущий ввод пользователя в интерфейсе калькулятора */
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; /* Получаем конкретную нажатую кнопку из общего объекта sender */
            currentInput += button.Text; /* Добавляет цифру или символ к текущему вводимому числу */
            textBox1.Text = currentInput; /* Отображает текущий ввод пользователя в интерфейсе калькулятора */
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; /* Получаем конкретную нажатую кнопку из общего объекта sender */
            currentInput += button.Text; /* Добавляет цифру или символ к текущему вводимому числу */
            textBox1.Text = currentInput; /* Отображает текущий ввод пользователя в интерфейсе калькулятора */
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; /* Получаем конкретную нажатую кнопку из общего объекта sender */
            currentInput += button.Text; /* Добавляет цифру или символ к текущему вводимому числу */
            textBox1.Text = currentInput; /* Отображает текущий ввод пользователя в интерфейсе калькулятора */
        }

        private void Evaluate() /* Объявление метода для вычисления/оценки */
        {
            if (operationPending) /* Проверка ожидающей операции, если operationPending = false, метод пропускает все вычисления */
            {
                double secondNumber = double.Parse(currentInput); /* Преобразует строку currentInput в число типа double */

                switch (operation) /* Анализирует значение переменной */
                {
                    case "+": /* Если операция "+", прибавляет secondNumber к result */
                        result += secondNumber;
                        break;
                    case "-": /* Если операция "-", вычитает secondNumber из result */
                        result -= secondNumber;
                        break;
                    case "*": /* Если операция "*", умножает result на secondNumber */
                        result *= secondNumber;
                        break;
                    case "/": /* */
                        if (secondNumber != 0) /* Проверяет, что делитель не равен нулю */
                        {
                            result /= secondNumber; /* Если не ноль - выполняет деление */
                        }
                        else
                        {
                            textBox1.Text = "Error"; /* Если ноль - показывает "Error" и выходит из метода (return) */
                            return;
                        }
                        break;
                }

                textBox1.Text = result.ToString(); /* Преобразует числовой result в строку */
                currentInput = ""; /* Очищает текущий ввод */
                operationPending = false; /* Сбрасывает флаг ожидания операции */

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (operationPending) /* Проверяет, есть ли невыполненная операция */
            {
                Evaluate(); /* Если operationPending = true, вызывает метод Evaluate() для выполнения предыдущей операции */
            }

            Button button = (Button)sender; /* Приводит объект sender к типу Button. Позволяет получить доступ к свойствам нажатой кнопки */
            operation = button.Text; /* Cохраняет выбранную математическую операцию для последующего выполнения */
            result = double.Parse(currentInput); /* Преобразует текущий ввод currentInput из строки в число типа double */
            currentInput = ""; /* Очищает строку currentInput, готовит поле для ввода второго числа */
            operationPending = true; /* Указывает, что операция выбрана и ожидается ввод второго числа */
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (operationPending) /* Проверяет, есть ли невыполненная операция */
            {
                Evaluate(); /* Если operationPending = true, вызывает метод Evaluate() для выполнения предыдущей операции */
            }

            Button button = (Button)sender; /* Приводит объект sender к типу Button. Позволяет получить доступ к свойствам нажатой кнопки */
            operation = button.Text; /* Cохраняет выбранную математическую операцию для последующего выполнения */
            result = double.Parse(currentInput); /* Преобразует текущий ввод currentInput из строки в число типа double */
            currentInput = ""; /* Очищает строку currentInput, готовит поле для ввода второго числа */
            operationPending = true; /* Указывает, что операция выбрана и ожидается ввод второго числа */
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (operationPending) /* Проверяет, есть ли невыполненная операция */
            {
                Evaluate(); /* Если operationPending = true, вызывает метод Evaluate() для выполнения предыдущей операции */
            }

            Button button = (Button)sender; /* Приводит объект sender к типу Button. Позволяет получить доступ к свойствам нажатой кнопки */
            operation = button.Text; /* Cохраняет выбранную математическую операцию для последующего выполнения */
            result = double.Parse(currentInput); /* Преобразует текущий ввод currentInput из строки в число типа double */
            currentInput = ""; /* Очищает строку currentInput, готовит поле для ввода второго числа */
            operationPending = true; /* Указывает, что операция выбрана и ожидается ввод второго числа */
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (operationPending) /* Проверяет, есть ли невыполненная операция */
            {
                Evaluate(); /* Если operationPending = true, вызывает метод Evaluate() для выполнения предыдущей операции */
            }

            Button button = (Button)sender; /* Приводит объект sender к типу Button. Позволяет получить доступ к свойствам нажатой кнопки */
            operation = button.Text; /* Cохраняет выбранную математическую операцию для последующего выполнения */
            result = double.Parse(currentInput); /* Преобразует текущий ввод currentInput из строки в число типа double */
            currentInput = ""; /* Очищает строку currentInput, готовит поле для ввода второго числа */
            operationPending = true; /* Указывает, что операция выбрана и ожидается ввод второго числа */
        }

        private void button15_Click(object sender, EventArgs e)
        {
            currentInput = ""; /* Очищает строку, хранящую текущие вводимые цифры */
            result = 0; /* Обнуляет переменную, хранящую результат вычислений */
            operation = ""; /* Очищает строку, хранящую текущую математическую операцию */
            operationPending = false; /* Сбрасывает состояние "ожидания ввода второго числа" */
            textBox1.Text = ""; /* Очищает текстовое поле калькулятора */
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Evaluate();
        }
    }
}
