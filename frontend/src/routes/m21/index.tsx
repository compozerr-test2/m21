import React from "react"
import { createFileRoute } from '@tanstack/react-router'
import M21Component from '../../m21-component'

export const Route = createFileRoute('/m21/')({
  component: RouteComponent,
})

function RouteComponent() {
  return (
    <div>
      <M21Component name="World!" />
    </div>
  )
}
