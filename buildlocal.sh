rm -rf _builds _steps _projects _cache _temp
wercker build --git-domain github.com --git-owner natallia-perets --git-repository netcore
rm -rf _builds _steps _projects _cache _temp