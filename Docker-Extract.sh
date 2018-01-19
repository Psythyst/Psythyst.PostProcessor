mkdir -p ./Publish
DIRECTORY="$( cd "$( dirname "${BASH_SOURCE[0]}" )" && pwd )"

DOCKER_VOLUME="$DIRECTORY/Publish:/Publish"
DOCKER_COMMAND="cp -R /Psythyst.PostProcessor/Psythyst.Plugin.PostProcessor.Entitas/Psythyst.Plugin.PostProcessor.Entitas/Psythyst.Plugin.PostProcessor.Entitas/Publish /"
DOCKER_IMAGE="psythyst/psythyst-post-processor:latest"

docker run -it --rm -v $DOCKER_VOLUME $DOCKER_IMAGE $DOCKER_COMMAND