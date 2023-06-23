# Game Box



## Build Docker Image
```bash
cd  <repo_root\gamebox>
docker image build -t <dockerId>/gamebox -f .\Server\Dockerfile .
```

## Run docker Image locally

```bash
docker run -p 80:80 <dockerId>/gamebox
```
Use browser to navigate to `http://localhost`

## Upload image to docker hub

```bash
docker push  <dockerId>/gamebox
```
