create database kezbesito default charset utf8 collate=utf8_hungarian_ci
Use kezbesito

select lap.cim, lap.havi, from lap where lap.havi!=0 order by lap.cim;