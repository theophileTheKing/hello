#!/bin/bash

# Variables
APP_URL="https://github.com/theophileTheKing/hello/releases/tag/1.0.0/hello"
INSTALL_DIR="/usr/local/bin"
EXECUTABLE_NAME="hello"

# Check if the script is run as root
if [ "$(id -u)" -ne 0 ]; then
    echo "Please run as root (use sudo)."
    exit 1
fi

# Download the app
echo "Downloading $EXECUTABLE_NAME..."
curl -L $APP_URL -o $INSTALL_DIR/$EXECUTABLE_NAME

# Set the executable permissions
chmod +x $INSTALL_DIR/$EXECUTABLE_NAME

# Confirm installation
echo "$EXECUTABLE_NAME installed successfully to $INSTALL_DIR."