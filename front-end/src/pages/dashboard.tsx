import { Box, Flex, SimpleGrid, Text } from '@chakra-ui/react'
import { Header } from '../components/Header'
import { Sidebar } from '../components/Sidebar'

export default function Home() {
  return (

    <Flex direction="column" h="100vh">
      <Header />

      <Flex w="100%" my="6" maxWidth={1480} mx="auto" px="6">

        <Sidebar />

        <SimpleGrid flex="1" gap="4" minChildWidth="320px" align="flex-start">
          <Box
            p="8"
            bg="gray.400"
            borderRadius={8}
            pg="4"
          >
            <Text
              fontSize="2xl" mb="4" color="gray.800">
              LOREM LOREM LOREM LOREM

            </Text>

          </Box>
        </SimpleGrid>

      </Flex>
    </Flex>

  )
}