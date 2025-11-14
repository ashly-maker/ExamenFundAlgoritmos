# Evidencias Git - Examen

1) git init
2) git checkout -b desarrollo
3) git remote add origin <https://github.com/ashly-maker/ExamenFundAlgoritmos.git>
4) touch README.md
5) echo "Nombre: AYTO PEREZ ASHLY - Sección: WA" > README.md
6) git add README.md
7) git commit -m "feat: agregar README con nombre y sección"
8) git commit -m "chore: ajuste de formato README"
9) git commit -m "docs: agregar estructura inicial de carpetas"
10) git push -u origin desarrollo

Simulando que hay conflicto:
11) git checkout -b correcciones
12) editar README.md (poner 'corrección A')
13) git add README.md
14) git commit -m "fix: corrección A en README"
15) git checkout desarrollo
16) editar README.md (poner 'corrección B')
17) git add README.md
18) git commit -m "fix: corrección B en README"
19) git merge correcciones
20) resolver conflicto en README.md manualmente
21) git add README.md
22) git commit -m "merge: resolver conflicto README"
23) git push origin desarrollo

Mensajes de entrega commit:
- feat: agregar README con nombre y sección
- chore: ajuste de formato README
- docs: agregar estructura inicial de carpetas
- fix: corrección A en README
- fix: corrección B en README
- merge: resolver conflicto README
