use steam

--23. Devuelve todos los juegos donde su precio final sea mayor a su precio inicial.

select Nombre,  PriceFinal, PriceInitial
from juegos
where  PriceFinal > PriceInitial

--24. Devuelve todos los juegos que no estén valorados en dólares.

select Nombre, PriceCurrency
from juegos
where PriceCurrency not like '%USD%'

--25. Devuelve todos los juegos que tengan una mayor nota que 0, pero que hayan suspendido.

select *
from juegos
where Metacritic > 0 and Metacritic < 50
order by Metacritic asc

--26. Devuelve el top 15 de juegos con mayor número de DLC.

select top 15 Nombre, DLCCount
from juegos
order by DLCCount desc


--27. Devuelve la información de los juegos que sólo se puedan jugar en Inglés.

select *
from juegos
where SupportedLanguages = 'English'  

--28. Devuelve el nombre(en minúscula) y la web (en mayúscula) de los juegos de acción o casuales.

select *
from juegos
where Genre = ' Actio' or genre = ' Casual'

--29. ¿Cuál es el juego indie con mayor nota? 

select top 1 with ties Metacritic, Nombre
from juegos
where Genre like '%Indie%' 
order by Metacritic desc

--30. ¿Y con menor nota?

select top 1 with ties Metacritic, Nombre
from juegos
where Genre like '%Indie%' 
order by Metacritic asc


