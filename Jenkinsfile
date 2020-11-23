#!/usr/bin/env groovy

pipeline {
    agent {
    	label 'dotnet'
    }

    stages {
        stage('Restore') {
            steps {
                sh 'dotnet restore'
            }
        }
        stage('Publish') {
            environment {
                DetailedVersion = sh(script: 'gitv -d', , returnStdout: true).trim()
            }
            steps {
                sh "dotnet pack Whyvra.Crypto.X25519 -c Release -o Build -p:Version=${DetailedVersion}"
                dir('Build') {
                    archiveArtifacts artifacts: " Whyvra.Crypto.X25519.${DetailedVersion}.nupkg", fingerprint: true
                }
            }
        }
    }
    post {
        cleanup {
            sh 'dotnet clean -c Release'
            deleteDir()
        }
    }
}