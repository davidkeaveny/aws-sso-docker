# AWS SSO

Demonstrating problem when attempting to use AWS SSO with Docker Compose.

Environment variables are defined in the Docker Compose file, and assume that your AWS SSO session is named `my-session` and the AWS profile is named `my-profile`.

```shell
aws sso login --profile my-profile
docker compose up -d
```
