# AntiVirusTestFramework
**AntiVirusTestFramework** состоит из двух фреймворков и тестов, написанных с их помощью, для проверки веб-приложения и десктоп-приложения.

Рассматривал вариант сделать над двумя фреймворками дополнительный уровень абстракции в виде общего API, на котором можно было бы писать тесты и для десктоп, и для веб версий приложения. Отказался от него в силу того, что функционал веб и десктоп версий может быть различен, даже если это версии одного продукта (чтобы как-то конкретизировать задачу фреймворки писались для гипотетического антивируса). 

Фреймворки написаны на основе [Selenium WebDriver](http://www.seleniumhq.org/) и [TestStack.White](https://github.com/TestStack/White). Первый является стандартом для тестирования веб-приложений. Второй был выбран из-за понятного API и возможности использовать фреймворк не только для тестирования приложений на **WinForms**, но и на **Win32**, **WPF**, **Silverlight**, что может быть полезно в случае появления новых продуктов со схожим функционалом, написанных c помощью одного из этих API.

В первую очередь были написаны **смоук тесты**, так как при автоматизации приложения они практически сразу дают ощутимый результат. Для реализации более специализированных тестов нужно больше времени на разработку фреймворка и они реже отлавливают баги. 


