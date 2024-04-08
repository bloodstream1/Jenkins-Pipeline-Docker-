pipeline {
    agent any

    // environment {
    //     DOTNET_CORE_SDK_VERSION = '3.1'
    //     IMAGE_NAME = 'myapp'
    //     IMAGE_TAG = 'latest'
    // }

    stages {
        stage('Checkout') {
            steps {
                // Checks out the source code
                checkout scm
            }
        }

        stage('Build') {
            steps {
                script {
                    // Restore, build, and publish using the .NET Core CLI
                    sh "dotnet restore"
                    sh "dotnet build --configuration Release"
                    // sh 'dotnet publish -c Release -o ./publish'
                }
            }
        }

        // stage('Test Docker') {
        //     steps {
        //         script {
        //             bat 'docker --version'
        //         }
        //     }
        // }

        stage('Build Docker Image') {
            steps {
                script {
                    // Building Docker image
                    sh 'docker build -t car-rental-image:latest -f "Car Rental Application/Dockerfile" .'
                }
            }
        }

        stage('Push Docker Image') {
            steps {
                script {
                    // Push the Docker image to a registry
                    sh 'docker login -u aakashtyagi11 -p aakash123'
                    sh 'docker tag  aakashtyagi11/latest'
                    sh "docker push aakashtyagi11/jenkins:latest"
                }
            }
        }
    }
}
