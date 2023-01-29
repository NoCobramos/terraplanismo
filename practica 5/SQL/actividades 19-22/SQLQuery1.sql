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