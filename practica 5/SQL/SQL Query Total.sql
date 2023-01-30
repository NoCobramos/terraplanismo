--1. Lista todas las columnas de la tabla.

select *
from juegos

--2. Lista todos los diferentes g�neros, eliminando duplicados.
select Genre
from dbo.juegos
group by Genre

--3. Lista �nicamente aquellos juegos que puedan ser jugados �nicamente en Linux.
select Nombre, PlatformLinux
from dbo.juegos
where PlatformLinux like '%True%' and PlatformMac like '%False' and PlatformWindows like '%False%'
--4. Lista todos los juegos de rol, ordenador por nota.

select Nombre, Genre, Metacritic
from dbo.juegos
where Genre like '%RPG%'
order by Metacritic desc;

--5. Lista todos aquellos juegos que puedan ser jugados en Espa�ol pero no en Franc�s.

select Nombre, SupportedLanguages
from dbo.juegos
where SupportedLanguages like '%Spanish%' and not SupportedLanguages like
'%French%';

--6. Lista el nombre del juego, su precio inicial, su precio final y la diferencia entre ambos en una nueva columna.

select Nombre, PriceInitial, PriceFinal, (PriceInitial-PriceFinal) as Diferencia
from dbo.juegos
--7. �Cu�ntos juegos hay del siglo pasado?

select count(nombre) as 'N� de Juegos'
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

--10. Devuelve todos aquellos juegos que est�n entre el 2000 y el 2010.

select *
from juegos
where ReleaseDate >= '2000' and ReleaseDate <= '2010'

--11. Devuelve todos los juegos que sean de la saga Final Fantasy.

select *
from juegos
where Nombre like '%Final Fantasy%'

--12. Devuelve todos los juegos que sean de deportes y haya trabajado m�s de 3 desarrolladores.

select *
from juegos
where Genre like '%sports%'

--13. �Cu�ntos juegos hay asociados a cada categor�a?

select category, count(nombre)
from juegos
group by Category

--16. �Cu�l es la m�xima y m�nima puntuaci�n por g�nero?

select Genre,max(Metacritic) as NotaMaxima, min(Metacritic) as NotaM�nima
from juegos
group by genre

--17. Usando Top, devuelve el top 10 de juegos con mayor puntuaci�n del 2012.

select top 10 Nombre, Metacritic
from juegos
where ReleaseDate = '2012'
order by Metacritic desc

--18. Usando top, devuelve el top 10 de juegos m�s nuevos de g�nero single player.

select top 10 Nombre, ReleaseDate
from juegos
order by ReleaseDate desc

--19. Devuelve la media de nota de todos aquellos juegos que sean para mayores de 18 a�os.

select avg(metacritic) as MediaNotas
from juegos
where RequiredAge >= 18

--20. �Cu�ntos juegos hay asociados a cada tipo (mayor de 18, de 17�)?

select count(Nombre) as CantidadJuegos, RequiredAge
from juegos
group by RequiredAge
order by RequiredAge asc

--21. Devuelve todos aquellos a�os en los que haya menos de 300 juegos.

select  ReleaseDate
from juegos
group by ReleaseDate
having  count(Nombre) < 300
order by ReleaseDate

--22. Devuelve todos los juegos que est�n para Mac pero no para Windows.

select *
from juegos
where PlatformMac = 'true' and PlatformWindows = 'false'

--23. Devuelve todos los juegos donde su precio final sea mayor a su precio inicial.

select Nombre,  PriceFinal, PriceInitial
from juegos
where  PriceFinal > PriceInitial

--24. Devuelve todos los juegos que no est�n valorados en d�lares.

select Nombre, PriceCurrency
from juegos
where PriceCurrency not like '%USD%'

--25. Devuelve todos los juegos que tengan una mayor nota que 0, pero que hayan suspendido.

select *
from juegos
where Metacritic > 0 and Metacritic < 50
order by Metacritic asc

--26. Devuelve el top 15 de juegos con mayor n�mero de DLC.

select top 15 Nombre, DLCCount
from juegos
order by DLCCount desc


--27. Devuelve la informaci�n de los juegos que s�lo se puedan jugar en Ingl�s.

select *
from juegos
where SupportedLanguages = 'English'  

--28. Devuelve el nombre(en min�scula) y la web (en may�scula) de los juegos de acci�n o casuales.

select *
from juegos
where Genre = ' Actio' or genre = ' Casual'

--29. �Cu�l es el juego indie con mayor nota? 

select top 1 with ties Metacritic, Nombre
from juegos
where Genre like '%Indie%' 
order by Metacritic desc

--30. �Y con menor nota?

select top 1 with ties Metacritic, Nombre
from juegos
where Genre like '%Indie%' 
order by Metacritic asc

--31. Devuelve toda la informaci�n del juego con menor nota, siempre que sea mayor a cero.

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
	
--33. Devuelve el juego con mayor nota del a�o 2008.

select top 1 with ties *
from juegos
where ReleaseDate = '2008'
order by Metacritic desc

--34. Devuelve toda la informaci�n de los juegos que valgan m�s que la media.

select *
from juegos
where Metacritic > (select avg(Metacritic)
from juegos
where Metacritic > 0)
	
--35. Devuelve toda la informaci�n de los juegos de Linux que tengan el mayor n�mero de logros (achivements)

select top 10 with ties Nombre
from juegos
where PlatformLinux = 'true'
order by AchievementCount desc





