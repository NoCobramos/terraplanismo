use steam

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
