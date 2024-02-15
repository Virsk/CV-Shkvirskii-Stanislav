const PROXY_CONFIG = [
  {
    context: [
      "/content"
    ],
    target: "https://localhost:7016",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
