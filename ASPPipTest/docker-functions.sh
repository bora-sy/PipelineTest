# Function to check if container exists
container_exists() {
  local name="$1"
  docker ps -a --format '{{.Names}}' | grep -qw "^${name}$"
}

# Function to check if image exists
image_exists() {
  local image_ref="$1"
  docker images --format '{{.Repository}}:{{.Tag}}' | grep -qw "^${image_ref}$"
}