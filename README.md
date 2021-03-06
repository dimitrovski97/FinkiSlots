**FinkiSlots – windows апликација – Проектна задача по предметот Визуелно програмиње**

   **Автор:** Димитар Димитровски - 161054
   
   **Опис на апликација:** FinkiSlots претставува една поинаква репрезентација на слот машина. Наместо јаболки, криши, сливи овде се вртат предметите од ФИНКИ од прва и втора година. Секој предмет е со различен коефициен на добива, а корисникот може да избира на колку линии сака да типува и со колку кредити по линија. На почетокот секој добива бесплатни 30 кредити. Кога ќе се потрошат корисникот може да си докупи уште кредити и да ја продолжи играта. Во моментот кога корисникот е задоволен од играта и сака да си оди ги повлекува парите преку соодветното поле. Правилата и условите како да се дојде до џекпот можат да се погледнат на почетокот на играта. (Услов за џекпот: Кога корисникот има останато точно 228 кредити и типува се паѓа џекпотот – Веројатност и статистика).
   
   **Имплементација:** Проектната задача е направена во програмскиот јазик C#. Користена околина за развој на апликацијата е Visual Studio 2017. Целиот код е напишан од страна на авторот освен за оној кој експлицитно е наведено во самиот проек. За обработка на сликите е користен Photoshop CS5. 
   
   **Технички опис на апликацијата:** При кликање на копчето BET или на space од тастатурата, се стартува тајмерот со интервал од 70мс. На неговото 10-то вртење застанува и се стартува методот -spin(). Откако ќе заврши се повикува методот за проверка на добивката – checkWin() и доколку има добивка се обележува линијата која се паднала. Потоа се ажурираат полињата Balance и LastWin. Доколку кориникот нема повеќе кредити, тој соодвето се известува преку MessageBox. За додавање на кредити и исплата се користат двете икони лоцирани во десниот дел од апликацијата. 
