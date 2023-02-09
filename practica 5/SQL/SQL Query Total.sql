--1. Lista todas las columnas de la tabla.

select *
from juegos

--2. Lista todos los diferentes géneros, eliminando duplicados.
select Genre
from dbo.juegos
group by Genre

--3. Lista únicamente aquellos juegos que puedan ser jugados únicamente en Linux.
select Nombre, PlatformLinux
from dbo.juegos
where PlatformLinux like '%True%' and PlatformMac like '%False' and PlatformWindows like '%False%'
--4. Lista todos los juegos de rol, ordenador por nota.

select Nombre, Genre, Metacritic
from dbo.juegos
where Genre like '%RPG%'
order by Metacritic desc;

--5. Lista todos aquellos juegos que puedan ser jugados en Español pero no en Francés.

select Nombre, SupportedLanguages
from dbo.juegos
where SupportedLanguages like '%Spanish%' and not SupportedLanguages like
'%French%';

--6. Lista el nombre del juego, su precio inicial, su precio final y la diferencia entre ambos en una nueva columna.

select Nombre, PriceInitial, PriceFinal, (PriceInitial-PriceFinal) as Diferencia
from dbo.juegos
--7. ¿Cuántos juegos hay del siglo pasado?

select count(nombre) as 'Nº de Juegos'
from juegos
where ReleaseDate < '2000'

--8. Devuelve todos los juegos que terminen o en N o en O.

select *
from juegos
where Nombre like '%N' or Nombre like '%O'

--9. Devuelve todos los juegos que empiecen por A y que se puedan jugar con mando.

select *
from juegos
where nombre like 'A%' and ControllerSupport = 'True'

--10. Devuelve todos aquellos juegos que estén entre el 2000 y el 2010.

select *
from juegos
where ReleaseDate >= '2000' and ReleaseDate <= '2010'

--11. Devuelve todos los juegos que sean de la saga Final Fantasy.

select *
from juegos
where Nombre like '%Final Fantasy%'

--12. Devuelve todos los juegos que sean de deportes y haya trabajado más de 3 desarrolladores.

select *
from juegos
where Genre like '%sports%'

--13. ¿Cuántos juegos hay asociados a cada categoría?

select category, count(nombre)
from juegos
group by Category

--16. ¿Cuál es la máxima y mínima puntuación por género?

select Genre,max(Metacritic) as NotaMaxima, min(Metacritic) as NotaMínima
from juegos
group by genre

--17. Usando Top, devuelve el top 10 de juegos con mayor puntuación del 2012.

select top 10 Nombre, Metacritic
from juegos
where ReleaseDate = '2012'
order by Metacritic desc

--18. Usando top, devuelve el top 10 de juegos más nuevos de género single player.

select top 10 Nombre, ReleaseDate
from juegos
order by ReleaseDate desc

--19. Devuelve la media de nota de todos aquellos juegos que sean para mayores de 18 años.

select avg(metacritic) as MediaNotas
from juegos
where RequiredAge >= 18

--20. ¿Cuántos juegos hay asociados a cada tipo (mayor de 18, de 17…)?

select count(Nombre) as CantidadJuegos, RequiredAge
from juegos
group by RequiredAge
order by RequiredAge asc

--21. Devuelve todos aquellos años en los que haya menos de 300 juegos.

select  ReleaseDate
from juegos
group by ReleaseDate
having  count(Nombre) < 300
order by ReleaseDate

--22. Devuelve todos los juegos que estén para Mac pero no para Windows.

select *
from juegos
where PlatformMac = 'true' and PlatformWindows = 'false'

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

--31. Devuelve toda la información del juego con menor nota, siempre que sea mayor a cero.

select top 1 with ties *
from juegos
where Metacritic > 0
order by Metacritic asc

--32. Devuelve aquellos juegos que tengan mayor nota que la media.

select Nombre
from juegos
where Metacritic > (select avg(Metacritic)
from juegos
where Metacritic > 0)
	
--33. Devuelve el juego con mayor nota del año 2008.

select top 1 with ties *
from juegos
where ReleaseDate = '2008'
order by Metacritic desc

--34. Devuelve toda la información de los juegos que valgan más que la media.

select *
from juegos
where Metacritic > (select avg(Metacritic)
from juegos
where Metacritic > 0)
	
--35. Devuelve toda la información de los juegos de Linux que tengan el mayor número de logros (achivements)

select top 10 with ties Nombre
from juegos
where PlatformLinux = 'true'
order by AchievementCount desc





