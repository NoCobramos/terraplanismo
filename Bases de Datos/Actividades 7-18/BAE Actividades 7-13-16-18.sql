use steam

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





